using Android.App;
using Android.Hardware;
using Android.Locations;
using Android.Widget;
using Android.OS;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tester
{
	[Activity (Label = "Tester1", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity, ISensorEventListener, ILocationListener
	{
		/*
		 * Accelerometer
		 */
		static readonly object _syncLock = new object();
		SensorManager _sensorManager;
		TextView _sensorTextView;

		/*
		 * GPS
		 */ 
		static readonly string TAG = "X:" + typeof (MainActivity).Name;
		TextView _addressText;
		Location _currentLocation;
		LocationManager _locationManager;

		string _locationProvider;
		TextView _locationText;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);

			/*
			 * Accelerometer
		 	 */
			_sensorManager = (SensorManager) GetSystemService(SensorService);
			_sensorTextView = FindViewById<TextView>(Resource.Id.accelerometer_text);

			/*
			 * GPS
			 */ 
			_addressText = FindViewById<TextView>(Resource.Id.address_text);
			_locationText = FindViewById<TextView>(Resource.Id.location_text);
			FindViewById<TextView>(Resource.Id.get_address_button).Click += AddressButton_OnClick;
			InitializeLocationManager();
		}

		public void OnAccuracyChanged(Sensor sensor, SensorStatus accuracy)
		{
			// We don't want to do anything here.
		}

		public void OnSensorChanged(SensorEvent e)
		{
			lock (_syncLock)
			{
				_sensorTextView.Text = string.Format("x={0:f}, y={1:f}, z={2:f}", e.Values[0], e.Values[1], e.Values[2]);
			}
		}

		protected override void OnResume()
		{
			base.OnResume();

			//Accelerometer
			_sensorManager.RegisterListener(this,
				_sensorManager.GetDefaultSensor(SensorType.Accelerometer),
				SensorDelay.Ui);

			//GPS
			_locationManager.RequestLocationUpdates(_locationProvider, 0, 0, this);
		}

		protected override void OnPause()
		{
			base.OnPause();

			//Accelerometer
			_sensorManager.UnregisterListener(this);

			//GPS
			_locationManager.RemoveUpdates(this);
		}

		public async void OnLocationChanged(Location location) {
			_currentLocation = location;
			if (_currentLocation == null)
			{
				_locationText.Text = "Unable to determine your location. Try again in a short while.";
			}
			else
			{
				_locationText.Text = string.Format("{0:f6},{1:f6}", _currentLocation.Latitude, _currentLocation.Longitude);
				Address address = await ReverseGeocodeCurrentLocation();
				DisplayAddress(address);
			}
		}

		public void OnProviderDisabled(string provider) {}

		public void OnProviderEnabled(string provider) {}

		public void OnStatusChanged(string provider, Availability status, Bundle extras) {}

		void InitializeLocationManager()
		{
			_locationManager = (LocationManager) GetSystemService(LocationService);
			Criteria criteriaForLocationService = new Criteria
			{
				Accuracy = Accuracy.Fine
			};
			IList<string> acceptableLocationProviders = _locationManager.GetProviders(criteriaForLocationService, true);

			if (acceptableLocationProviders.Any())
			{
				_locationProvider = acceptableLocationProviders.First();
			}
			else
			{
				_locationProvider = string.Empty;
			}
			//Log.Debug(TAG, "Using " + _locationProvider + ".");
		}

		async void AddressButton_OnClick(object sender, EventArgs eventArgs)
		{
			if (_currentLocation == null)
			{
				_addressText.Text = "Can't determine the current address. Try again in a few minutes.";
				return;
			}

			Address address = await ReverseGeocodeCurrentLocation();
			DisplayAddress(address);
		}

		async Task<Address> ReverseGeocodeCurrentLocation()
		{
			Geocoder geocoder = new Geocoder(this);
			IList<Address> addressList =
				await geocoder.GetFromLocationAsync(_currentLocation.Latitude, _currentLocation.Longitude, 10);

			Address address = addressList.FirstOrDefault();
			return address;
		}

		void DisplayAddress(Address address)
		{
			if (address != null)
			{
				StringBuilder deviceAddress = new StringBuilder();
				for (int i = 0; i < address.MaxAddressLineIndex; i++)
				{
					deviceAddress.AppendLine(address.GetAddressLine(i));
				}
				// Remove the last comma from the end of the address.
				_addressText.Text = deviceAddress.ToString();
			}
			else
			{
				_addressText.Text = "Unable to determine the address. Try again in a few minutes.";
			}
		}

	}
}
