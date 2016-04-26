using Android.App;
using Android.Content;
using Android.Hardware;
using Android.Locations;
using Android.Widget;
using Android.OS;
using Android.Util;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Plugin.Vibrate;
using System.Threading;

namespace Gigabyke
{
	public class Accelerometer : Activity, Java.IO.ISerializable, ISensorEventListener
	{
		private static readonly object _syncLock = new object(); // Acts like a semaphore
		private static readonly object _queueLock = new object();// Acts like a semaphore
		private SensorManager _sensorManager;
		private TextView _accValues;
		private TextView _gforceView;
		private TextView _max;
		private Queue<Events> _eventQueue = new Queue<Events>();

		private double _thresholdMeter;
		private double _calibrMax;
		private double _factor;
		private bool _calibrationActive = false;
		private bool _hasVibrator = false;
		private int _grotePutCounter = 0;
		private bool _stopAcc = false;
		private bool _writeAccess = true;

		private long _elapsed;
		private Stopwatch _sw;
		private Stopwatch _threadWatch;
		private Events events;
		private int _lage;
		private int _hoge;

		public Accelerometer (SensorManager manager, TextView values, TextView gforce, TextView max, bool hasVibrator)
		{
			this._sensorManager = manager;
			this._accValues = values;
			this._gforceView = gforce;
			this._thresholdMeter = 1;
			this._max = max;
			this._hasVibrator = hasVibrator;
			this._factor = 0;
			this._sw = new Stopwatch();
			this._elapsed = 0;
			this._threadWatch = new Stopwatch ();
			_lage = 0;
			_hoge = 0;
		}

		public Accelerometer (SensorManager manager, bool hasVibrator)
		{
			this._sensorManager = manager;
			this._thresholdMeter = 13;
			this._calibrationActive = true;
			this._hasVibrator = hasVibrator;
			this._factor = 0;
		}

		/*
		 * Called when the accuracy of the sensor had changed
		 */
		public void OnAccuracyChanged(Sensor sensor, SensorStatus accuracy)
		{
			// Geen code aanwezig
		}

		/*
		 * Called when the value of the sensor has changed
		 */
		public void OnSensorChanged(SensorEvent e)
		{
			// Lock the object such that only this method can modify some values
			lock (_syncLock)
			{
				if (_calibrationActive == false) {
					
					// If the calibration is not active, but the sensor hasn't been calibrated yet:
					// Inform the user that he has to calibrate the device first
					if (_factor == 0) {
						_accValues.Text = "Eerst kalibreren aub";
						_gforceView.Text = "";
					} else {
						
						// Otherwise: process the value
						processAlgorithm (e.Values [0], e.Values [1], e.Values [2]);
					}
				} else {

					// If the calibration process is active:
					// Calculate the G-force on the device
					// When that force is greater than the highest measurement:
					// Set that measurement as the highest one
					double g = Math.Sqrt (
						Math.Pow (e.Values [0], 2) + 
						Math.Pow (e.Values [1], 2) + 
						Math.Pow (e.Values [2], 2));
					if (g > _thresholdMeter) {
						_calibrMax = g;
					}
				}
			}
		}

		/*
		 * Called when the accelerometer has to stop measuring
		 * The value _stopAcc is set to TRUE such that the running threads
		 * 		will be stopped
		 */ 
		public void stopAccelerometer() {
			_stopAcc = true;
			_sensorManager.UnregisterListener (this);
		}

		/*
		 * Called when the accelerometer has to start measuring
		 * The value _stopAcc is set to FALSE such that the threads can be started.
		 * A listener is registred in the sensormanager so the method "OnValueChanged" 
		 * 		will be called.
		 */
		public void startAccelerometer() {
			Console.WriteLine ("Accelerometer starten");
			_stopAcc = false;
			_sensorManager.RegisterListener (this,
				_sensorManager.GetDefaultSensor (SensorType.Accelerometer),
				SensorDelay.Ui);

			// If the calibration process is not active: restart the stopwatch and start the threads
			if (!_calibrationActive) {
				_sw.Restart ();
				executeThread ();
				executeAnalyzeThread ();
			}
			Console.WriteLine ("Accelerometer gestart");
		}

		/*
		 *  Setter for _factor
		 */
		public void setFactor(double factor) {
			this._factor = factor;
		}

		/*
		 *  Setter for _thresholdMeter
		 */
		public void setThreshold(double thresh) {
			this._thresholdMeter = thresh;
		}

		/*
		 *  The calibration process
		 */
		public double calibrate() {

			// Get the milliseconds at the start of the process
			double ticksStart = Java.Lang.JavaSystem.CurrentTimeMillis();
			double maxG = 0;
			double mean = 0;


			for (int i = 1; i <= 5; i++) {

				// The highest measurement will be set as the maximum
				// 		if it's higher than the previous maximum
				// Run this loop for 1 second
				do {
					if(maxG < _calibrMax)
						maxG = _calibrMax;

				} while((ticksStart + 1000 * i) > Java.Lang.JavaSystem.CurrentTimeMillis ());

				// Summation for calculating the mean of the 5 highest measurements
				mean += maxG;
				maxG = 0;
				if(_hasVibrator)
					CrossVibrate.Current.Vibration (100);
			}

			// When the 5 seconds have elapsed: vibrate to inform the user that the calibration process
			// has ended
			if(_hasVibrator)
				CrossVibrate.Current.Vibration (500);

			// Return the calculated mean value
			return mean/5;

		}

		/*
		 *  Called when the value of the accelerometer has changed, 
		 * 		to process the values of that meter
		 */
		private void processAlgorithm(float e1, float e2, float e3) {

			// Calculate the value on a scale from 0 to 20
			// This ensures that every smartphone uses the same scale
			double newG = (Math.Sqrt (Math.Pow (e1, 2) + Math.Pow (e2, 2) + Math.Pow (e3, 2)) - 9.81) * _factor;

			// Print this values to the user interface
			_accValues.Text = string.Format ("Waardes: x={0:f}, y={1:f}, z={2:f}", e1, e2, e3);
			_gforceView.Text = string.Format ("G Force: {0:f}", newG);

			if (newG > _thresholdMeter) {

				// Restart _threadWatch and get the current time in milliseconds
				_threadWatch.Restart ();
				_elapsed = Java.Lang.JavaSystem.CurrentTimeMillis ();

				// Lock the object to ensure that nothing can modify the queue during the process
				lock (_queueLock) {

					// Generate a new event with:
					// 		ID = 1 (ID of an accelerometer event)
					//		Elapsed milliseconds
					//		Magnitude
					events = new Events (1, _elapsed, newG);

					// Place that event in the queue
					_eventQueue.Enqueue (events);

					// Notify every 
					Monitor.PulseAll(_queueLock);

				}

				if (_writeAccess) {
					var path = global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
					FileStream fs = null;
					if (!File.Exists (path.ToString () + "/magnitudes.txt")) {
						fs = File.Create (path.ToString () + "/magnitudes.txt");
					} else {
						fs = File.Open (path.ToString () + "/magnitudes.txt", FileMode.Append);
					}
					StreamWriter sw = new StreamWriter (fs);
					sw.WriteLine (newG);
					sw.Flush ();
					sw.Close ();

					FileStream fs1 = null;
					if (!File.Exists (path.ToString () + "/time.txt")) {
						fs1 = File.Create (path.ToString () + "/time.txt");

					} else {
						fs1 = File.Open (path.ToString () + "/time.txt", FileMode.Append);
					}
					StreamWriter sw1 = new StreamWriter (fs1);
					sw1.WriteLine (_elapsed);
					sw1.Flush ();
					sw1.Close ();

				}
				vibrate (100);

				_gforceView.SetBackgroundColor (Android.Graphics.Color.Red);//.Transparent);
			} else {
				_gforceView.SetBackgroundColor (Android.Graphics.Color.Transparent);
			}

		}

		public void vibrate(int duration) {
			if(_hasVibrator)
				CrossVibrate.Current.Vibration (duration);
		}

		public void analyseData(){
			int threshold = 1;

			if (_eventQueue.Count <= 1) {

			} else {
				Events secEv = _eventQueue.Dequeue ();
				double rico =  System.Math.Abs((_eventQueue.Peek ().getMagnitude() - secEv.getMagnitude())/(_eventQueue.Peek ().getMilliseconds() - secEv.getMilliseconds()));
				rico = rico * 1000;
				Console.WriteLine (rico);
				if (rico > threshold || _sw.ElapsedMilliseconds > 3000) {
					
					if (secEv.getMagnitude () >= 14) {
						Console.WriteLine ("ANALYZE DATA: Groteputcounter++");
						_grotePutCounter++;
					}
					_lage = 0;
					_hoge++;
					Console.Write ("Lage: ");
					Console.Write (_lage);
					Console.Write (", hoge: ");
					Console.WriteLine (_hoge);
				} else {
					Console.WriteLine ("ANALYZE DATA: Rico kleiner dan threshold");
					Console.Write ("STOPWATCH: ");
					Console.WriteLine (_sw.ElapsedMilliseconds.ToString());
					_lage++;
				}
				_sw.Restart ();

			}
		}

		public void executeThread() {
			Console.WriteLine ("ExecuteThread: Thread starten");
			new System.Threading.Thread (new System.Threading.ThreadStart (
				() => {
					while(!_stopAcc){
						lock(_queueLock){
							while(_eventQueue.Count <= 1){
								Monitor.Wait(_queueLock);
							}
						}
						analyseData();
					}

				}
			)).Start ();
			Console.WriteLine ("Thread gestart");
		}

		public void executeAnalyzeThread() {
			Console.WriteLine ("ExecuteAnalyzeThread: Thread starten");
			new System.Threading.Thread (new System.Threading.ThreadStart (
				() => {
					_threadWatch.Restart();
					while(!_stopAcc) {
						if(_lage >= 2 || _threadWatch.ElapsedMilliseconds >= 1250){
							Console.WriteLine ("ANALYZE DATA: Beeindigen van putmeting");
							if (_hoge >= 20) {
								Console.WriteLine ("ANALYZE DATA: KASSEIWEG");
								setMaxText ("KASSEIWEG");
							} else if(_grotePutCounter >= 1) {
								setMaxText("GROTE PUT");
								_grotePutCounter = 0;
							} else if (_hoge >= 2) {
								if (_grotePutCounter >= 1) {
									Console.WriteLine ("ANALYZE DATA: GROTE PUT");
									_grotePutCounter = 0;
									setMaxText ("GROTE PUT");
								} else {
									Console.WriteLine ("ANALYZE DATA: PUT");
									setMaxText ("PUT");
								}
							} else {
								Console.WriteLine ("ANALYZE DATA: '' ''");
								setMaxText ("");
							}
							_hoge = 0;
							_lage = 0;
							_threadWatch.Restart();
						}

						Thread.Sleep(20);
					}
					Console.WriteLine ("ExecuteAnalyzeThread: Thread gestopt");
				}
			)).Start ();
		}

		public void setMaxText(string tekst) {
			RunOnUiThread (() => {
				_max.Text = tekst;

				if(_writeAccess) {
					var path =  global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
					FileStream fs = null;
					if(!File.Exists(path.ToString() + "/putten.txt")) {
						fs = File.Create(path.ToString() + "/putten.txt");
					} else {
						fs = File.Open (path.ToString()+ "/putten.txt",FileMode.Append);
					}
					StreamWriter sw = new StreamWriter(fs);
					sw.Write(Java.Lang.JavaSystem.CurrentTimeMillis ());
					sw.Write (": ");
					sw.WriteLine(tekst);
					sw.Flush();
					sw.Close();
				}

			});
		}
	}
}