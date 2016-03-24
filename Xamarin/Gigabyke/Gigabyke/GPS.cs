using Android.App;
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
	public class GPS : Activity,ILocationListener
	{
		TextView _locationText;
		Location _currentLocation;
		LocationManager _locationManager;
		string _locationProvider;

		public GPS (LocationManager locationManager, TextView locationText)
		{
			this._locationText = locationText;
			this._locationText.Text = "Initialiseren";
			this._locationManager = locationManager;
		}

		/*
		 * GPS
		 * Wordt opgeroepen wanneer de locatie wijzigt
		 */
		public void OnLocationChanged(Location location) {
			_currentLocation = location;
			if (_currentLocation == null)
			{
				_locationText.Text = "Locatie bepalen is mislukt. Probeer een andere keer";
			}
			else
			{
				_locationText.Text = string.Format("Breedte: {0:f6} - Lengte: {1:f6}", _currentLocation.Latitude, _currentLocation.Longitude);
				// Await: wacht totdat de functie 'ReverseGeocodeCurrentLocation' zijn waarde heeft teruggegeven.
				//Address address = await ReverseGeocodeCurrentLocation();
				//DisplayAddress(address);
			}
		}

		/*
		 * Methodes die aanwezig zijn, maar niet geïmplementeerd zijn.
		 */
		public void OnProviderDisabled(string provider) {}
		public void OnProviderEnabled(string provider) {}
		public void OnStatusChanged(string provider, Availability status, Bundle extras) {	}

		/*
		 * GPS
		 * Initialiseer de locationmanager
		 */
		public void InitializeLocationManager()
		{
			// Maak een nieuw criterium aan voor de location service. De nauwkeurigheid moet fijn zijn.
			Criteria criteriaForLocationService = new Criteria
			{
				Accuracy = Accuracy.Fine
			}; 

			// Maak een lijst aan met alle acceptabele location providers
			IList<string> acceptableLocationProviders = _locationManager.GetProviders(criteriaForLocationService, true);

			if (acceptableLocationProviders.Any())
			{
				// Als er location providers in de lijst staan: neem de eerste.
				_locationProvider = acceptableLocationProviders.First();
			}
			else
			{
				// Als er geen location providers zijn: geef een lege string.
				_locationProvider = string.Empty;
			}

			// Schrijf de gebruikte location provider naar de debug console
			//Log.Debug(TAG, "Using " + _locationProvider + ".");

		}

		public void stopGPS() {
			_locationManager.RemoveUpdates (this);
		}

		public void startGPS() {
			_locationManager.RequestLocationUpdates (_locationProvider, 0, 0, this);
		}
	}
}

