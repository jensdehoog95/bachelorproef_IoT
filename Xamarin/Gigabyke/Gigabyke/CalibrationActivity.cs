
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Plugin.Vibrate;

using Gigabyke;
using Android.Hardware;
using System.Threading.Tasks;

namespace Gigabyke
{
	[Activity (Theme = "@style/Theme.Gigabyke_Calibr", Label = "Kalibratie")]			
	public class CalibrationActivity : Activity
	{
		Accelerometer meter;
		TextView infoLabel;
		Button calibrateButton;
		double calibrateMax;
		double factor;
		bool _complete = false;
		bool _hasVibrator;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Calibration);
			infoLabel = FindViewById<TextView> (Resource.Id.textMessage);
			calibrateButton = FindViewById<Button> (Resource.Id.startButton);

			Vibrator vibrator = (Vibrator)GetSystemService (Context.VibratorService);
			_hasVibrator = vibrator.HasVibrator;

			meter = new Accelerometer ((SensorManager)GetSystemService (SensorService),_hasVibrator);

			infoLabel.Text = "Blijf schudden met het toestel todat hij trilt.\n" +
			"Klik op de knop om te starten";

			calibrateButton.Click += (sender, e) => {
				// Check if the calibration is finished.
				// if yes: terminate the calibration.
				// if no: start the calibration.
				if(!_complete) {
					infoLabel.Text = "Aan het meten...";

					// Start a new thread
					// Starts the accelerometer, kalibrates and then stops the accelerometer.
					Task.Factory.StartNew(
						() => {
							meter.startAccelerometer();
							calibrateMax = meter.calibrate();
							meter.stopAccelerometer();
						}
					// After thread is terminated, do these tasks.
					).ContinueWith (
						t => {
							//Calculate the factor
							factor = 0.21854;//20 / (calibrateMax - 9.81);
							infoLabel.Text = string.Format("{0:f5}",factor);

							// Converr the calibrationbutton to a finishbuttor.
							calibrateButton.Text = "Beëindig";

							// Now the calibration is done, the button gets another function.
							_complete = true;
						}, TaskScheduler.FromCurrentSynchronizationContext()
						// TaskScheduler... makes sure that the tasks after the executed thread will be executed in the main thread.
					);
				} else {
					// Make a new transition ready to the previous activity.
					Intent resultData = new Intent();
					resultData.PutExtra("CalibrationFactor",factor);
					SetResult(Result.Ok,resultData);
					Finish();
				}
			};
		}
	}
}

