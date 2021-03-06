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
		private double _thresholdMeterBackup;
		private double _calibrMax;
		private double _factor;
		private bool _calibrationActive = false;
		private bool _hasVibrator = false;
		private int _grotePutCounter = 0;
		private bool _stopAcc = false;

		private int _counter;
		private long _elapsed;
		private Stopwatch _sw;
		private Stopwatch _putWatch;
		private Events events;

		public Accelerometer (SensorManager manager, TextView values, TextView gforce, TextView max, bool hasVibrator)
		{
			this._sensorManager = manager;
			this._accValues = values;
			this._gforceView = gforce;
			this._thresholdMeter = 1;
			this._thresholdMeterBackup = 1;
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
			this._thresholdMeterBackup = 13;
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
			_stopAcc = true;
			_sensorManager.UnregisterListener (this);
		}

		public void startAccelerometer() {
			Console.WriteLine ("Accelerometer starten");
			_stopAcc = false;
			_sensorManager.RegisterListener (this,
				_sensorManager.GetDefaultSensor (SensorType.Accelerometer),
				SensorDelay.Ui);

			if (!_calibrationActive) {
				_sw.Restart ();
				executeThread ();
			}
			Console.WriteLine ("Accelerometer gestart");
		}

		public void setFactor(double factor) {
			this._factor = factor;
		}

		public void setThreshold(double thresh) {
			this._thresholdMeter = thresh;
			this._thresholdMeterBackup = thresh;
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

			_elapsed = Java.Lang.JavaSystem.CurrentTimeMillis ();
			if (newG > _thresholdMeter) {
				events = new Events (1, _elapsed, newG);
				_eventQueue.Enqueue (events);
				vibrate (100);
				/*
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
				} */
				_gforceView.SetBackgroundColor (Android.Graphics.Color.Red);//.Transparent);
			} else {
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

		public void executeThread() {
			Console.WriteLine ("ExecuteThread: Thread starten");
			new System.Threading.Thread (new System.Threading.ThreadStart (
				() => {
					ArrayList listEvents = new ArrayList ();
					int resetCounter = 0;
					Console.WriteLine ("ExecuteThread: ArrayList aangemaakt");
					while (!_stopAcc) {
						Java.Lang.Thread.Sleep(1000);
						if (_eventQueue.Count <= 1) {
							resetCounter++;
							_grotePutCounter = 0;
							if (resetCounter >= 5 && _thresholdMeterBackup != _thresholdMeter) {
								_thresholdMeter = _thresholdMeterBackup;
								resetCounter = 0;
								setMaxText("");
							} else if( resetCounter >= 5){
								_eventQueue.Clear();
								resetCounter = 0;
								setMaxText("");
							}
							Console.WriteLine ("ExecuteThread: wachten op events");
						} else {
							
							Events ev = _eventQueue.Peek ();
							if (ev.getID () == 1) {
								listEvents.Add (_eventQueue.Dequeue ());
								long millis = ev.getMilliseconds ();
								bool stopWhile = false;
								while(!stopWhile && _eventQueue.Count > 0) {
									Events secEv = _eventQueue.Peek ();
									if (secEv.getMilliseconds () - millis <= 500) {
										listEvents.Add (_eventQueue.Dequeue ());
										Console.WriteLine("ExecuteThread: geschreven naar ArrayList");
									} else {
										stopWhile = true;
									} 
								}
							}
							processList (listEvents);
							resetCounter = 0;
							listEvents.Clear();
						}
					}
					Console.WriteLine ("Thread gestopt");
				}
			)).Start ();
			Console.WriteLine ("Thread gestart");
		}

		public int processList(ArrayList list) {
			Events firstEvent = (Events) list [0];
			Events lastEvent = (Events) list [list.Count - 1];

			if(list.Count == 1) {
				// Gewoon negeren
				setMaxText ("");
				return 1;

			} else if (list.Count >= 2 && list.Count <= 4) {
				if (_grotePutCounter <= 2) {	
					_grotePutCounter++;
					setMaxText ("PUT!");
					return 2;
				} else {
					setMaxText("KASSEIWEG");
					Console.WriteLine ("Threshold op 3 gezet");
					_thresholdMeter = 3;
					return 4;
				}
			} else if (list.Count >= 5 && list.Count <= 8) {
				if (_grotePutCounter == 0) {
					_grotePutCounter++;
					setMaxText("GROTE PUT!");
					return 3;
				} else {
					setMaxText("KASSEIWEG");
					_thresholdMeter = 3;
					return 4;
				}
			} else {
				setMaxText("KASSEIWEG");
				Console.WriteLine ("Threshold op 3 gezet");
				_thresholdMeter = 3;
				return 4;
			}
		}

		public void setMaxText(string tekst) {
			RunOnUiThread (() => {
				_max.Text = tekst;
			});
		}
	}
}
