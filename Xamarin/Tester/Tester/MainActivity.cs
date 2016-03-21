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
using Org.Eclipse.Paho.Client.Mqttv3;
using Org.Eclipse.Paho.Client.Mqttv3.Internal;
using Org.Eclipse.Paho.Client.Mqttv3.Logging;
using Org.Eclipse.Paho.Client.Mqttv3.Persist;
using Org.Eclipse.Paho.Client.Mqttv3.Util;

namespace Tester
{
	[Activity (Theme = "@android:style/Theme.Material.Light.DarkActionBar", Label = "TestBach", MainLauncher = true, Icon = "@mipmap/icon")]
	//
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
		TextView _maxText;
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
			_maxText = FindViewById<TextView>(Resource.Id.textMax);
			FindViewById<TextView>(Resource.Id.get_address_button).Click += AddressButton_OnClick; // Koppel de functie achter
				// de knop aan de knop zelf
			FindViewById<TextView>(Resource.Id.get_address_button).Enabled = false;
			InitializeLocationManager(); // Roep initialisatiefunctie op
			/*
			string content;
			Android.Content.Res.AssetManager assets = this.Assets;
			using (StreamReader sr = new StreamReader (assets.Open ("Brightness.txt"))) 
			{
				content = sr.ReadToEnd ();
			}
			_addressText.Text = content; */

			//utilMQTT ();
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
				//_sensorTextView.Text = string.Format("x={0:f}, y={1:f}, z={2:f}", e.Values[0], e.Values[1], e.Values[2]);
				double g = Math.Sqrt(Math.Pow(e.Values[0],2) + Math.Pow(e.Values[1],2) + Math.Pow(e.Values[2],2));
				_sensorTextView.Text = string.Format ("G Force: {0:f}", g);
				if (g > 18.5) {
					_sensorTextView.SetBackgroundColor (Android.Graphics.Color.Red);
					_maxText.Text = g.ToString();
				} else {
					_sensorTextView.SetBackgroundColor (Android.Graphics.Color.Transparent);
				}

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

		//Notification
			// Instantiate the builder and set notification elements:
			Notification.Builder builder = new Notification.Builder (this)
				.SetContentTitle ("Notification")
				.SetContentText ("Adres is ingesteld!")
				.SetSmallIcon (Resource.Drawable.noti);

			// Build the notification:
			Notification notification = builder.Build();

			// Get the notification manager:
			NotificationManager notificationManager =
				GetSystemService (Android.Content.Context.NotificationService) as NotificationManager;

			// Publish the notification:
			const int notificationId = 0;
			notificationManager.Notify (notificationId, notification);
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

		void utilMQTT() {
			Ping ping = new Ping ();

			String topic        = "home/temperature";
			String content      = "Message from MqttPublishSample";
			int qos             = 2;
			String ipBroker		= "192.168.0.163";
			String broker       = "tcp://" + ipBroker + ":1883";
			String clientId     = "JavaSample";
			MemoryPersistence persistence = new MemoryPersistence();

			PingReply pingReply = ping.Send (ipBroker);

			if (pingReply.Status != IPStatus.Success) {
				_addressText.Text = "Ping mislukt";
			} else {
				MqttClient sampleClient = new MqttClient (broker, clientId, persistence);
				MqttConnectOptions connOpts = new MqttConnectOptions ();
				connOpts.CleanSession = true;
				sampleClient.Connect (connOpts);
				MqttMessage message = new MqttMessage (GetBytes (content));
				message.Qos = qos;
				sampleClient.Publish (topic, message);
				sampleClient.Disconnect ();
			}
		}

		static byte[] GetBytes(string str)
		{
			byte[] bytes = new byte[str.Length * sizeof(char)];
			System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
			return bytes;
		}

	}
}