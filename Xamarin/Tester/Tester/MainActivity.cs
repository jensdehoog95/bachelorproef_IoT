using Android.App;
using Android.Hardware;
using Android.Locations;
using Android.Widget;
using Android.OS;
using Android.Util;
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
		static readonly object _syncLock = new object(); // Object dat enkel uitgelezen kan worden
		SensorManager _sensorManager; // Laat de developer de sensoren van het apparaat benaderen
		TextView _sensorTextView; // Tekst die zichtbaar is naar de gebruiker, geeft sensorgegevens weer

		/*
		 * GPS
		 */ 
		static readonly string TAG = "X:" + typeof (MainActivity).Name; // String die enkel uitgelezen kan worden
		TextView _addressText; // Geeft adresgegevens weer naar gebruiker
		Location _currentLocation; // Representeert een geografische locatie
		LocationManager _locationManager; // Verleent toegang tot locatieservices van het systeem

		string _locationProvider; // String die locatieprovider bevat
		TextView _locationText; // Geeft locatiegegevens weer naar gebruiker

		/*
		 * Wordt als eerste functie opgeroepen, initialiseert alles
		 */ 
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);

			/*
			 * Accelerometer
		 	 */
			_sensorManager = (SensorManager) GetSystemService(SensorService); // Verkrijg service van systeem
			_sensorTextView = FindViewById<TextView>(Resource.Id.accelerometer_text); // Koppel textview aan textlabel in GUI

			/*
			 * GPS
			 */ 
			_addressText = FindViewById<TextView>(Resource.Id.address_text); // Koppel textview aan textlabel in GUI
			_locationText = FindViewById<TextView>(Resource.Id.location_text); // Koppel textview aan textlabel in GUI
			FindViewById<TextView>(Resource.Id.get_address_button).Click += AddressButton_OnClick; // Koppel de functie achter
				// de knop aan de knop zelf
			InitializeLocationManager(); // Roep initialisatiefunctie op
	
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
				_sensorTextView.Text = string.Format("x={0:f}, y={1:f}, z={2:f}", e.Values[0], e.Values[1], e.Values[2]);
			}
		}

		/*
		 * Wordt aangeroepen wanneer de applicatie wordt hervat
		 */
		protected override void OnResume()
		{
			base.OnResume();

			// Accelerometer
			// Registreert een sensorlistener bij de manager
			// "GetDefaultSensor": 	De default sensor voor accelerometer wordt meegegeven als argument
			// "SensorDelay.Ui": 	Gebruik een uitleesdelay die van toepasselijk is voor de GUI
			_sensorManager.RegisterListener(this,
				_sensorManager.GetDefaultSensor(SensorType.Accelerometer),
				SensorDelay.Ui);

			// GPS
			// Registreer voor updates van de locatie
			// "_locationProvider":	Naam van de provider die geregistreerd wordt
			// "0":					Minimum tijd tussen de updates, in miliseconden
			// "0":					Minimum afstand tussen de updates, in meters
			// "this":				Listener bij welke de methode 'OnLocationChange' opgeroepen wordt
			_locationManager.RequestLocationUpdates(_locationProvider, 0, 0, this);
		}

		/*
		 * Wordt opgeroepen wanneer de applicatie gepauseerd wordt
		 */
		protected override void OnPause()
		{
			base.OnPause();

			// Accelerometer
			// Deactiveer de sensoruitlezing
			// BELANGRIJK: anders verbruikt dit te veel energie
			_sensorManager.UnregisterListener(this);

			// GPS
			// Deactiveer updates over de locatie
			// BELANGRIJK: anders verbruikt dit te veel energie
			_locationManager.RemoveUpdates(this);
		}

		/*
		 * GPS
		 * Wordt opgeroepen wanneer de locatie wijzigt
		 */
		public async void OnLocationChanged(Location location) {
			_currentLocation = location;
			if (_currentLocation == null)
			{
				_locationText.Text = "Locatie bepalen is mislukt. Probeer een andere keer";
			}
			else
			{
				_locationText.Text = string.Format("Breedte: {0:f6} - Lengte: {1:f6}", _currentLocation.Latitude, _currentLocation.Longitude);
				// Await: wacht totdat de functie 'ReverseGeocodeCurrentLocation' zijn waarde heeft teruggegeven.
				Address address = await ReverseGeocodeCurrentLocation();
				DisplayAddress(address);
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
		void InitializeLocationManager()
		{
			_locationManager = (LocationManager) GetSystemService(LocationService); // Verkrijg de service van het systeem

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
			Log.Debug(TAG, "Using " + _locationProvider + ".");

		}

		/*
		 * GPS
		 * Asynchrone methode die de functie achter de knop verzorgt.
		 */
		async void AddressButton_OnClick(object sender, EventArgs eventArgs)
		{
			// Als de huidige locatie 'null' is, geef foutmelding weer
			if (_currentLocation == null)
			{
				_addressText.Text = "Kan adres niet bepalen. Probeer later opnieuw.";
				return; // Verbreek de methode
			}

			// Verkrijg een adres uit de methode 'ReverseGeocodeCurrentLocation'
			Address address = await ReverseGeocodeCurrentLocation();

			// Stuur het adres naar de GUI
			DisplayAddress(address);
		}

		/*
		 * GPS
		 * Asynchrone methode die latitude en longitude kan omzetten naar adres
		 */
		async Task<Address> ReverseGeocodeCurrentLocation()
		{
			// Geocoder kan de vertaling maken tussen coördinaten en adressen
			Geocoder geocoder = new Geocoder(this);

			// Maak een lijst met daarin maximaal 10 mogelijke adressen op deze locatie
			IList<Address> addressList =
				await geocoder.GetFromLocationAsync(_currentLocation.Latitude, _currentLocation.Longitude, 10);

			// Verkrijg het eerste of default adres
			Address address = addressList.FirstOrDefault();

			return address;
		}

		/*
		 * GPS
		 * Methode die het adres weergeeft op de GUI
		 */
		void DisplayAddress(Address address)
		{
			if (address != null)
			{
				// Stringbuilder plakt verschillende strings aan elkaar
				StringBuilder deviceAddress = new StringBuilder();

				// Plak alle lijnen van het adres in één string aan elkaar
				for (int i = 0; i < address.MaxAddressLineIndex; i++)
				{
					deviceAddress.AppendLine(address.GetAddressLine(i));
				}

				// Stel het tekstveld van de GUI gelijk aan de samengevoegde string.
				_addressText.Text = deviceAddress.ToString();
			}
			else
			{
				_addressText.Text = "Adres bepalen mislukt. Probeer later opnieuw.";
			}
		}

	}
}