using System;
using System.Threading;

namespace testen
{

	using deleteFiles;
	using  = org.eclipse.paho.client.mqttv3.0 * ;
	using Utils = de.dobermai.eclipsemagazin.paho.client.util.Utils;

	/// <summary>
	/// @author Dominik Obermaier
	/// @author Christian G�tz
	/// </summary>

	public class Publisher
	{
		public static File tempFile = new File("Temperature.txt");
		public static File BrightFile = new File("Brightness.txt");
		public const string TOPIC_BRIGHTNESS = "home/brightness";
		public const string TOPIC_TEMPERATURE = "home/temperature";

		private MqttClient client;

		public Publisher()
		{
		}

		//Get the file of the temperature
		public virtual File TemperatureFile
		{
			get
			{
				return tempFile;
			}
		}

		//Get the file of the brightness
		public virtual File BrightnessFile
		{
			get
			{
				return BrightFile;
			}
		}

		//The publisher starts
		private void start()
		{
			 string clientId = Utils.MacAddress + "-pub"; //get unique ID


			 try
			 {
				 client = new MqttClient("tcp://0.0.0.0:1883", clientId); //initiliaze MQTTClient

			 }
			 catch (MqttException e)
			 {
				 Console.WriteLine(e.ToString());
				 Console.Write(e.StackTrace);
				 Environment.Exit(1);
			 }
			try
			{
				MqttConnectOptions options = new MqttConnectOptions();
				options.CleanSession = false;
				options.setWill(client.getTopic("home/LWT"), "I'm gone :(".GetBytes(), 0, false);
				//Sets the "Last Will and Testament" (LWT) for the connection. 
				//In the event that this client unexpectedly loses its connection to the server, the server will publish a message to itself using the supplied details.
				client.connect(options); //connect to client

				//Publish data forever
				while (true)
				{

					publishBrightness();

					Thread.Sleep(500);

					publishTemperature();

					Thread.Sleep(5000);
				}
			}
			catch (MqttException e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
				Environment.Exit(1);
			}
			catch (InterruptedException e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
		}

		//Generate a random value for the temperature and publish it
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: private void publishTemperature() throws MqttException
		private void publishTemperature()
		{
//JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
//ORIGINAL LINE: final MqttTopic temperatureTopic = client.getTopic(TOPIC_TEMPERATURE);
			MqttTopic temperatureTopic = client.getTopic(TOPIC_TEMPERATURE); //Set topic

//JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
//ORIGINAL LINE: final int temperatureNumber = de.dobermai.eclipsemagazin.paho.client.util.Utils.createRandomNumberBetween(20, 30);
			int temperatureNumber = Utils.createRandomNumberBetween(20, 30);
//JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
//ORIGINAL LINE: final String temperature = temperatureNumber + "�C";
			string temperature = temperatureNumber + "�C";

			temperatureTopic.publish(new MqttMessage(temperature.GetBytes()));

			string messag = temperature.ToString() + "\n";
			try
			{
				Files.write(Paths.get("Temperature.txt"), messag.GetBytes(), StandardOpenOption.APPEND); //Write to the file
			}
			catch (IOException e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}

			Console.WriteLine("Published data. Topic: " + temperatureTopic.Name + "  Message: " + temperature);
		}

		//Generate a random value for the brightness and publish it
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: private void publishBrightness() throws MqttException
		private void publishBrightness()
		{
//JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
//ORIGINAL LINE: final MqttTopic brightnessTopic = client.getTopic(TOPIC_BRIGHTNESS);
			MqttTopic brightnessTopic = client.getTopic(TOPIC_BRIGHTNESS); //Set topic

//JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
//ORIGINAL LINE: final int brightnessNumber = de.dobermai.eclipsemagazin.paho.client.util.Utils.createRandomNumberBetween(0, 100);
			int brightnessNumber = Utils.createRandomNumberBetween(0, 100);
//JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
//ORIGINAL LINE: final String brigthness = brightnessNumber + "%";
			string brigthness = brightnessNumber + "%";

			brightnessTopic.publish(new MqttMessage(brigthness.GetBytes()));

			string messag = brigthness.ToString() + "\n";
			try
			{
				Files.write(Paths.get("Brightness.txt"), messag.GetBytes(), StandardOpenOption.APPEND); //Write to the file
			}
			catch (IOException e)
			{
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}

			Console.WriteLine("Published data. Topic: " + brightnessTopic.Name + "   Message: " + brigthness);
		}

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static void main(String... args) throws java.io.IOException
		public static void Main(params string[] args)
		{
			//Delete files before startup
			File directory = new File("Temperature.txt");
			CrunchifyDeleteFiles.deleteThisFile(directory);
			   directory = new File("Brightness.txt");
			   CrunchifyDeleteFiles.deleteThisFile(directory);
			PrintWriter writer = new PrintWriter(tempFile, "UTF-8");
			PrintWriter writer2 = new PrintWriter(BrightFile, "UTF-8");
//JAVA TO C# CONVERTER WARNING: The original Java variable was marked 'final':
//ORIGINAL LINE: final Publisher publisher = new Publisher();
			Publisher publisher = new Publisher();
			publisher.start();
			writer.close();
			writer2.close();
		}
	}
}