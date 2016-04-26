using Android.App;
using Android.Hardware;
using Android.Locations;
using Android.Widget;
using Android.OS;
using Android.Util;
using Android.Support.Design.Widget;
using Android.Views;
using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gigabyke
{
	public class GPS : Activity,ILocationListener
	{
		TextView _locationText;
		Location _currentLocation;
		LocationManager _locationManager;
		string _locationProvider;

		private bool _writeAccess;

		public GPS (LocationManager locationManager, TextView locationText, bool writeAccess)
		{
			this._locationText = locationText;
			this._locationText.Text = "Initialiseren";
			this._locationManager = locationManager;
			this._writeAccess = writeAccess;
		}

		/*
		 * GPS
		 * get called when the location changes.
		 */
		public void OnLocationChanged(Location location) {
			//Try to get the location
			_currentLocation = location;
			if (_currentLocation == null)
			{
				_locationText.Text = "Locatie bepalen is mislukt. Probeer een andere keer";
			}
			else
			{
				string locText = string.Format("Breedte: {0:f6} - Lengte: {1:f6}", _currentLocation.Latitude, _currentLocation.Longitude);
				_locationText.Text = locText;

				//Write the coordinates to a file.
				if (_writeAccess) {
					var path = global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
					FileStream fs = null;
					if (!File.Exists (path.ToString () + "/gps.txt")) {					
						fs = File.Create (path.ToString () + "/gps.txt");
					} else {
						fs = File.Open (path.ToString () + "/gps.txt", FileMode.Append);
					}
					StreamWriter sw = new StreamWriter (fs);
					sw.Write (Java.Lang.JavaSystem.CurrentTimeMillis ());
					sw.Write (": ");
					sw.WriteLine (locText);
					sw.Flush ();
					sw.Close ();
				}
			}
		}

		/*
		 * Methodes that there are but not implemented.
		 */
		public void OnProviderDisabled(string provider) {}
		public void OnProviderEnabled(string provider) {}
		public void OnStatusChanged(string provider, Availability status, Bundle extras) {}

		/*
		 * GPS
		 * Initialize the locationmanager.
		 */
		public void InitializeLocationManager()
		{
			//Make a new criterion for the location service. The accuracy must be Fine.
			Criteria criteriaForLocationService = new Criteria
			{
				Accuracy = Accuracy.Fine
			}; 

			//Make a list with all acceptable location providers.
			IList<string> acceptableLocationProviders = _locationManager.GetProviders(criteriaForLocationService, true);

			if (acceptableLocationProviders.Any())
			{
				//if there are location providers in the list: take the first one.
				_locationProvider = acceptableLocationProviders.First();
			}
			else
			{
				//if there aren't location providers: give an empty string.
				_locationProvider = string.Empty;
			}
		}

		//Stops the GPS.
		public void stopGPS() {
			_locationManager.RemoveUpdates (this);
		}

		//Starts the GPS.
		public void startGPS() {
			_locationManager.RequestLocationUpdates (_locationProvider, 0, 0, this);
		}
	}
}

