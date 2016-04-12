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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Plugin.Vibrate;

namespace Gigabyke
{
	public class Accelerometer : Activity, Java.IO.ISerializable, ISensorEventListener
	{
		private static readonly object _syncLock = new object();
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

		private int _counter;
		private double _elapsed;
		private Stopwatch _sw;
		private Stopwatch _putWatch;
		private Events events;

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
			this._counter = 0;
			this._elapsed = 0;
			this._putWatch = new Stopwatch ();
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
		 * Accelerometer
		 * Wordt opgeroepen wanneer de nauwkeurigheid van de sensor wijzigt
		 */
		public void OnAccuracyChanged(Sensor sensor, SensorStatus accuracy)
		{
			// Geen code aanwezig
		}

		/*
		 * Accelerometer
		 * Wordt opgeroepen wanneer de sensordata is gewijzigd
		 */
		public void OnSensorChanged(SensorEvent e)
		{
			lock (_syncLock)
			{
				if (_calibrationActive == false) {
					if (_factor == 0) {
						_accValues.Text = "Eerst kalibreren aub";
						_gforceView.Text = "";
					} else {
						processAlgorithm (e.Values [0], e.Values [1], e.Values [2]);
					}
				} else {
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

		public void stopAccelerometer() {
			_sensorManager.UnregisterListener (this);
		}

		public void startAccelerometer() {
			_sensorManager.RegisterListener (this,
				_sensorManager.GetDefaultSensor (SensorType.Accelerometer),
				SensorDelay.Ui);

			if (!_calibrationActive)
				_sw.Restart();
		}

		public void setFactor(double factor) {
			this._factor = factor;
		}

		public void setThreshold(double thresh) {
			this._thresholdMeter = thresh;
		}

		public double calibrate() {
			double ticksStart = Java.Lang.JavaSystem.CurrentTimeMillis();
			double maxG = 0;
			double mean = 0;


			for (int i = 1; i <= 5; i++) {
				do {

					if(maxG < _calibrMax)
						maxG = _calibrMax;

				} while((ticksStart + 1000 * i) > Java.Lang.JavaSystem.CurrentTimeMillis ());
				mean += maxG;
				maxG = 0;
				if(_hasVibrator)
					CrossVibrate.Current.Vibration (100);
			}

			if(_hasVibrator)
				CrossVibrate.Current.Vibration (500);
			return mean/5;

		}

		/*
		 * Algoritme om putten in het wegdek te detecteren
		 */
		private void processAlgorithm(float e1, float e2, float e3) {
			double newG = (Math.Sqrt (Math.Pow (e1, 2) + Math.Pow (e2, 2) + Math.Pow (e3, 2)) - 9.81) * _factor;
			// Bereken de newG die vergeleken moet worden met de threshold
			double tempTreshold = _thresholdMeter;

			_accValues.Text = string.Format ("Waardes: x={0:f}, y={1:f}, z={2:f}", e1, e2, e3);
			_gforceView.Text = string.Format ("G Force: {0:f}", newG);

			_elapsed = _sw.ElapsedMilliseconds;
			if (newG > _thresholdMeter) {
				events = new Events (1, _elapsed, newG);
				_eventQueue.Enqueue (events);
				double difference = 0;
				int oneTime = 0;
				double initialValue = 0;
				foreach (Events ev in _eventQueue) 
				{
					if (oneTime == 0) {
						oneTime++;
						initialValue = ev.getMilliseconds();
					}
					double time = ev.getMilliseconds();
					difference = time - initialValue;
					_counter++;
					if (difference >= 1250) {
						/*for (int i = 0; i < _counter; i++) {
							_eventQueue.Dequeue ();
						}*/
						String maxText = "";
						if (_counter >= 2 && _counter <= 4) {
							maxText = "PUT!";
						} else if (_counter > 4) {
							maxText = "KASSEIWEG!";
						}
						oneTime = 0;
						_counter = 0;
						_max.Text = maxText;
					}
					if (_counter >= 5 && _counter <= 8) {
						if (difference <= 650) {
							_max.Text = "GROTE PUT!";
							oneTime = 0;
							_counter = 0;
							/*for (int i = 0; i < _counter; i++) {
								_eventQueue.Dequeue ();
							}*/
						}
					}

				}
					
				//Als de newG groter is dan de threshold, dan verhogen we de counter en starten we de putWatch
				_counter++;
				_putWatch.Start ();
				vibrate (100);

			} else {
				if (_elapsed >= 1250) {
					//Check of de verstreken tijd gelijk of groter is dan 1,25s
					String maxText;
					if (_counter >= 2 && _counter <= 4) {
						//Bij een lage counter hebben we te maken met een gewone put
						maxText = "PUT!";
					} else if (_counter > 4) {
						//Bij een hoge counter hebben we te maken met een kasseiweg
						//We verlagen daarom onze threshold naar 3 om goed te kunnen detecteren
						maxText = _counter.ToString ();
						tempTreshold = _thresholdMeter;
						_thresholdMeter = 3;
					} else {
						//Een counter van 1 of een andere onverwachte waarde negeren we
						maxText = "";
						_thresholdMeter = tempTreshold;
						_grotePutCounter = 0;
					}
					_max.Text = maxText;
					restartMeasurement ();
				} 

				if (_counter >= 5 && _counter <= 8) {
					if (_putWatch.ElapsedMilliseconds <= 650) {
						//Bij een grote counter op korte tijd hebben we te maken met een grote put
						if (_grotePutCounter >= 1) {
							//Er mag maar 1 grote put op de korte tijd gedetecteerd worden. Alle anderen worden genegeerd
							_max.Text = _counter.ToString ();
						} else {
							//Verhoog de grotePutCounter en voer restartMeasurement uit
							_max.Text = "GROTE PUT!";
							//Task.Delay (500);
							_grotePutCounter++;
							restartMeasurement ();
						}
					}
				}
				_gforceView.SetBackgroundColor (Android.Graphics.Color.Transparent);
			}
		}

		public void vibrate(int duration) {
			if(_hasVibrator)
				CrossVibrate.Current.Vibration (duration);
		}

		/*
		 * Reset voor de stopwatches en zet de counter terug op 0 
		 */
		public void restartMeasurement() {
			_putWatch.Reset ();
			_sw.Restart ();
			_counter = 0;
		}
	}
}

