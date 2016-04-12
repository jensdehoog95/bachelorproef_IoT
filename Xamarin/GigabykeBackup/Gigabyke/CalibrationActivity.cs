
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
		Button finishButton;
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
				// Check of de kalibratie al voltooid is
				// Zo ja: beëindig activiteit
				// Zo nee: start kalibratie
				if(!_complete) {
					infoLabel.Text = "Aan het meten...";

					// Start nieuwe thread
					// Gaat accelerometer starten, kalibreren en dan terug stopzetten
					Task.Factory.StartNew(
						() => {
							meter.startAccelerometer();
							calibrateMax = meter.calibrate();
							meter.stopAccelerometer();
						}
					// Nadat thread beëindigd is, voer deze taken uit
					).ContinueWith (
						t => {
							// Bereken factor
							factor = 20 / (calibrateMax - 9.81);
							infoLabel.Text = string.Format("{0:f5}",factor);

							// Zet de kalibratieknop om naar een finishknop
							calibrateButton.Text = "Beëindig";

							// Nu is de kalibratie voltooid, de knop krijgt een andere functie
							_complete = true;
						}, TaskScheduler.FromCurrentSynchronizationContext()
						// TaskScheduler... zorgt ervoor dat de taken na de uitgevoerde thread op de main thread worden uitgevoerd
					);
				} else {
					// Maak een nieuwe overgang klaar naar de vorige activiteit
					Intent resultData = new Intent();
					resultData.PutExtra("CalibrationFactor",factor);
					SetResult(Result.Ok,resultData);
					Finish();
				}
			};
		}
	}
}

