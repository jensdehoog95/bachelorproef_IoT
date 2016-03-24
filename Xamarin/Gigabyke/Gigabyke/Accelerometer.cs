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

namespace Gigabyke
{
	public class Accelerometer : Activity,ISensorEventListener
	{
		private static readonly object _syncLock = new object();
		private SensorManager _sensorManager;
		private TextView _viewAcc;
		private TextView _max;

		private double thresholdMeter;

		public Accelerometer (SensorManager manager, TextView view, TextView max)
		{
			this._sensorManager = manager;
			this._viewAcc = view;
			this.thresholdMeter = 10;
			this._max = max;
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
				double g = Math.Sqrt(Math.Pow(e.Values[0],2) + Math.Pow(e.Values[1],2) + Math.Pow(e.Values[2],2));
				_viewAcc.Text = string.Format ("G Force: {0:f}", g);
				if (g > thresholdMeter) {
					_viewAcc.SetBackgroundColor (Android.Graphics.Color.Red);
					_max.Text = g.ToString();
				} else {
					_viewAcc.SetBackgroundColor (Android.Graphics.Color.Transparent);
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
		}

		public void setThreshold(double thresh) {
			this.thresholdMeter = thresh;
		}
	}
}

