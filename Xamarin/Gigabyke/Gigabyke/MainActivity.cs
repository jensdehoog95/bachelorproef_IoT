using Android.App;
using Android.Hardware;
using Android.Locations;
using Android.Widget;
using Android.OS;
using Android.Util;
using System;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Support.V4.App;
using Android.Content.PM;
using Android.Content;

namespace Gigabyke
{
	[Activity (Theme = "@style/Theme.Gigabyke", Label = "Gigabyke", MainLauncher = true, Icon = "@mipmap/icon", ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : Activity
	{
		const int stepSeekBar = 5;
		bool _hasVibrator;

		TextView _accValues;
		TextView _accText;
		TextView _gpsText;
		TextView _sliderText;
		TextView _maxText;
		EditText _topicText;
		EditText _contentText;
		Button _sendButton;
		Button _calibrateButton;
		SeekBar _slider;

		Accelerometer accelerometer;
		GPS gps;

		View layout;

		static readonly int REQUEST_COARSELOCATION = 0;
		static readonly int REQUEST_FINELOCATION = 1;
		static readonly int REQUEST_INTERNET = 2;
		static readonly int REQUEST_WRITE_EXTERNAL_STORAGE = 3;
		static readonly int REQUEST_READ_EXTERNAL_STORAGE = 4;

		//Set the permissions that are needed.
		static string[] PERMISSIONS_CONTACT = {
			Android.Manifest.Permission.AccessCoarseLocation,
			Android.Manifest.Permission.AccessFineLocation,
			Android.Manifest.Permission.Internet,
			Android.Manifest.Permission.WriteExternalStorage,
			Android.Manifest.Permission.ReadExternalStorage
		};

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			layout = null;
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			_accValues = FindViewById<TextView> (Resource.Id.accValues);
			_accText = FindViewById<TextView> (Resource.Id.accView);
			_gpsText = FindViewById<TextView> (Resource.Id.gpsView);

			_sliderText = FindViewById<TextView> (Resource.Id.textSlider);
			_maxText = FindViewById<TextView> (Resource.Id.textMax);

			_topicText = FindViewById<EditText> (Resource.Id.topicText);
			_contentText = FindViewById<EditText> (Resource.Id.contentText);

			_sendButton = FindViewById<Button> (Resource.Id.sendButton);
			_calibrateButton = FindViewById<Button> (Resource.Id.calibrateButton);
			_slider = FindViewById<SeekBar> (Resource.Id.slider);

			_maxText.TextSize = 65;

			Vibrator vibrator = (Vibrator)GetSystemService (Context.VibratorService);
			_hasVibrator = vibrator.HasVibrator;

			//Setup slider
			_slider.ProgressChanged += delegate(object sender, SeekBar.ProgressChangedEventArgs e) {

				double step = e.Progress/stepSeekBar;
				double newStep = Math.Round(step);
				double newProgress = newStep + 1;
				accelerometer.setThreshold(newProgress);
				_sliderText.Text = newProgress.ToString();
				_slider.Progress = ((int)newStep * stepSeekBar);
			};

			_calibrateButton.Click += (sender, e) => {

				accelerometer.stopAccelerometer();

				//Make ready a transition to a new activity.
				var second = new Android.Content.Intent(this,typeof(CalibrationActivity));

				//Give a transition a request number. In this case '1'.
				StartActivityForResult(second,1);

				//Overwrite the transitionanimation with a new animation.
				OverridePendingTransition(Resource.Animation.abc_popup_enter,Resource.Animation.abc_slide_out_bottom);
			};

			accelerometer = new Accelerometer ((SensorManager)GetSystemService (SensorService),_accValues, _accText, _maxText, _hasVibrator);
			gps = new GPS ((LocationManager)GetSystemService (LocationService), _gpsText);
			initLocationManager ();

		}

		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data) {
			if (resultCode == Result.Ok && requestCode == 1) {

				//Get the factor that is given through the second activity.
				double factor = data.GetDoubleExtra ("CalibrationFactor", 0);

				// Use that factor to set the accelerometer.
				accelerometer.setFactor (factor);

				// Start the accelerometer.
				accelerometer.startAccelerometer ();
			}
		}

		//Pause the app.
		protected override void OnPause ()
		{
			base.OnPause ();
			gps.stopGPS ();
		}

		//Resume the app.
		protected override void OnResume ()
		{
			base.OnResume ();
			accelerometer.startAccelerometer();
			gps.startGPS ();
		}

		public void test() {
			
		}

		//Check if permissions are granted.
		public void initLocationManager() {
			if (ActivityCompat.CheckSelfPermission (this, Android.Manifest.Permission.AccessCoarseLocation) != (int)Android.Content.PM.Permission.Granted) {

				// CoarseLocation permission has not been granted
				RequestCoarsePermission ();
			}
			if (ActivityCompat.CheckSelfPermission (this, Android.Manifest.Permission.AccessFineLocation) != (int)Android.Content.PM.Permission.Granted) {
				
				// FineLocation permission has not been granted
				RequestFinePermission ();
			}
			if (ActivityCompat.CheckSelfPermission (this, Android.Manifest.Permission.Internet) != (int)Android.Content.PM.Permission.Granted) {

				// Internet permission has not been granted
				RequestInternetPermission ();
			}

			if (ActivityCompat.CheckSelfPermission (this, Android.Manifest.Permission.WriteExternalStorage) != (int)Android.Content.PM.Permission.Granted) {

				// WriteExternalStorage permission has not been granted
				RequestWriting ();
			}
			if (ActivityCompat.CheckSelfPermission (this, Android.Manifest.Permission.ReadExternalStorage) != (int)Android.Content.PM.Permission.Granted) {

				// ReadExternalStorage permission has not been granted
				RequestReading ();
			}

			gps.InitializeLocationManager ();
		}

		/**
     	* Requests the CoarseLocation permission.
		* If the permission has been denied previously, a SnackBar will prompt the user to grant the
		* permission, otherwise it is requested directly.
		*/
		void RequestCoarsePermission ()
		{
			if (ActivityCompat.ShouldShowRequestPermissionRationale (this, Android.Manifest.Permission.AccessCoarseLocation)) {
				Snackbar.Make (layout, Resource.String.hello,
					Snackbar.LengthIndefinite).SetAction (Resource.String.hello, new Action<View> (delegate(View obj) {
						ActivityCompat.RequestPermissions (this, new String[] { Android.Manifest.Permission.AccessCoarseLocation }, REQUEST_COARSELOCATION);
					})).Show ();
			} else {
				// AccessCoarseLocation permission has not been granted yet. Request it directly.
				ActivityCompat.RequestPermissions (this, new String[] { Android.Manifest.Permission.AccessCoarseLocation }, REQUEST_COARSELOCATION);
			}
		}

		/**
     	* Requests the FineLocation permission.
		* If the permission has been denied previously, a SnackBar will prompt the user to grant the
		* permission, otherwise it is requested directly.
		*/
		void RequestFinePermission ()
		{
			if (ActivityCompat.ShouldShowRequestPermissionRationale (this, Android.Manifest.Permission.AccessCoarseLocation)) {
				Snackbar.Make (layout, Resource.String.hello,
					Snackbar.LengthIndefinite).SetAction (Resource.String.hello, new Action<View> (delegate(View obj) {
						ActivityCompat.RequestPermissions (this, new String[] { Android.Manifest.Permission.AccessFineLocation }, REQUEST_FINELOCATION);
					})).Show ();
			} else {
				// AccessFineLocation permission has not been granted yet. Request it directly.
				ActivityCompat.RequestPermissions (this, new String[] { Android.Manifest.Permission.AccessFineLocation }, REQUEST_FINELOCATION);
			}
		}

		/**
     	* Requests the WriteExternalStorage permission.
		* If the permission has been denied previously, a SnackBar will prompt the user to grant the
		* permission, otherwise it is requested directly.
		*/
		void RequestWriting ()
		{
			if (ActivityCompat.ShouldShowRequestPermissionRationale (this, Android.Manifest.Permission.WriteExternalStorage)) {
				Snackbar.Make (layout, Resource.String.hello,
					Snackbar.LengthIndefinite).SetAction (Resource.String.hello, new Action<View> (delegate(View obj) {
						ActivityCompat.RequestPermissions (this, new String[] { Android.Manifest.Permission.WriteExternalStorage }, REQUEST_WRITE_EXTERNAL_STORAGE);
					})).Show ();
			} else {
				// WriteExternalStorage permission has not been granted yet. Request it directly.
				ActivityCompat.RequestPermissions (this, new String[] { Android.Manifest.Permission.WriteExternalStorage}, REQUEST_WRITE_EXTERNAL_STORAGE);
			}
		}

		/**
     	* Requests the ReadExternalStorage permission.
		* If the permission has been denied previously, a SnackBar will prompt the user to grant the
		* permission, otherwise it is requested directly.
		*/
		void RequestReading ()
		{
			if (ActivityCompat.ShouldShowRequestPermissionRationale (this, Android.Manifest.Permission.ReadExternalStorage)) {
				Snackbar.Make (layout, Resource.String.hello,
					Snackbar.LengthIndefinite).SetAction (Resource.String.hello, new Action<View> (delegate(View obj) {
						ActivityCompat.RequestPermissions (this, new String[] { Android.Manifest.Permission.ReadExternalStorage }, REQUEST_READ_EXTERNAL_STORAGE);
					})).Show ();
			} else {
				// ReadExternalStorage permission has not been granted yet. Request it directly.
				ActivityCompat.RequestPermissions (this, new String[] { Android.Manifest.Permission.ReadExternalStorage }, REQUEST_READ_EXTERNAL_STORAGE);
			}
		}

		/**
     	* Requests the Internet permission.
		* If the permission has been denied previously, a SnackBar will prompt the user to grant the
		* permission, otherwise it is requested directly.
		*/
		void RequestInternetPermission ()
		{
			if (ActivityCompat.ShouldShowRequestPermissionRationale (this, Android.Manifest.Permission.AccessCoarseLocation)) {
				Snackbar.Make (layout, Resource.String.hello,
					Snackbar.LengthIndefinite).SetAction (Resource.String.hello, new Action<View> (delegate(View obj) {
						ActivityCompat.RequestPermissions (this, new String[] { Android.Manifest.Permission.Internet }, REQUEST_INTERNET);
					})).Show ();
			} else {
				// Internet permission has not been granted yet. Request it directly.
				ActivityCompat.RequestPermissions (this, new String[] { Android.Manifest.Permission.Internet }, REQUEST_INTERNET);
			}
		}
	}
}


