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

		private double _thresholdMeter;
		private double _calibrMax;
		private double _factor;
		private bool _calibrationActive = false;
		private bool _hasVibrator = false;

		private int counter;
		private double elapsed;
		private Stopwatch sw;

		public Accelerometer (SensorManager manager, TextView values, TextView gforce, TextView max, bool hasVibrator)
		{
			this._sensorManager = manager;
			this._accValues = values;
			this._gforceView = gforce;
			this._thresholdMeter = 1;
			this._max = max;
			this._hasVibrator = hasVibrator;
			this._factor = 0;
			this.sw = new Stopwatch();
			//sw.Start();
			this.counter = 0;
			this.elapsed = 0;

		}

		public Accelerometer (SensorManager manager, bool hasVibrator)
		{
			this._sensorManager = manager;
			this._accValues = null;
			this._gforceView = null;
			this._thresholdMeter = 13;
			this._max = null;
			this._calibrationActive = true;
			this._hasVibrator = hasVibrator;
			this._factor = 0;
			this.sw = new Stopwatch ();
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
				// Parse de waardes van 'e' naar een mooie string
				double g = Math.Sqrt (Math.Pow (e.Values [0], 2) + Math.Pow (e.Values [1], 2) + Math.Pow (e.Values [2], 2));
				if (_calibrationActive == false) {
					if (_factor == 0) {
						_accValues.Text = "Eerst kalibreren aub";
						_gforceView.Text = "";
					} else {
						double newG = (g - 9.81) * _factor;
						_accValues.Text = string.Format ("Waardes: x={0:f}, y={1:f}, z={2:f}", e.Values [0], e.Values [1], e.Values [2]);
						_gforceView.Text = string.Format ("G Force: {0:f}", newG);

						elapsed = sw.ElapsedMilliseconds;
						if (newG > _thresholdMeter) {
							counter++;
							if (elapsed >= 1500) {
								if (counter >= 2 && counter <= 5) {
									_gforceView.SetBackgroundColor (Android.Graphics.Color.Red);
									_max.Text = string.Format ("{0:f6}", newG);
									sw.Restart ();
									counter = 0;
								} else if (counter > 5) {
									_gforceView.SetBackgroundColor (Android.Graphics.Color.Red);
									_max.Text = counter.ToString ();
									sw.Restart ();
									counter = 0;
								} else {
									_max.Text = "";
									sw.Restart ();
									counter = 0;
								}
							}
							//if (elapsed > 5000) {
							//	sw.Restart ();
							//	counter = 0;
							//}

							//_gforceView.SetBackgroundColor (Android.Graphics.Color.Red);
							//_max.Text = string.Format ("{0:f2}", newG);
							if (_hasVibrator)
								CrossVibrate.Current.Vibration (100);
						} else {
							_gforceView.SetBackgroundColor (Android.Graphics.Color.Transparent);
						}
					}
				} else {
					if (g > _thresholdMeter) {
						_calibrMax = g;
						//CrossVibrate.Current.Vibration (100);
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
			sw.Reset ();
			sw.Start ();
		}

		public void setFactor(double factor) {
			this._factor = factor;
		}

		public void setThreshold(double thresh) {
			this._thresholdMeter = thresh;
		}

		public double calibrate() {
			bool proceed = false;

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
	}
}

