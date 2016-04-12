using System;
using System.Net.NetworkInformation;
using Org.Eclipse.Paho.Client.Mqttv3;
using Org.Eclipse.Paho.Client.Mqttv3.Internal;
using Org.Eclipse.Paho.Client.Mqttv3.Logging;
using Org.Eclipse.Paho.Client.Mqttv3.Persist;
using Org.Eclipse.Paho.Client.Mqttv3.Util;

namespace Gigabyke
{
	public class MQTT
	{
		private String topic;
		private String content;
		private int qos;
		private String broker;
		private String clientID;

		private Boolean serverAvailable;

		//private MemoryPersistence persistence;
		private MqttClient client;

		public MQTT ()
		{
			//this.persistence = new MemoryPersistence ();
		}

		public MQTT (String broker) {
			//this.persistence = new MemoryPersistence ();
			this.broker = broker;
		}

		public void setBroker (String broker) {
			this.broker = broker;
		}

		public void setClientID (String clientID) {
			this.clientID = clientID;
		}

		public void setAvailable(Boolean available) {
			this.serverAvailable = available;
		}

		public Boolean getAvailable() {
			return this.serverAvailable;
		}

		public void initMQTT() {
			if (this.serverAvailable == true) {
				//this.client = new MqttClient (broker, clientID, persistence);
				this.client = new MqttClient (broker, clientID);
				MqttConnectOptions connOpts = new MqttConnectOptions ();
				connOpts.CleanSession = true;
				this.client.Connect (connOpts);
			}
		}

		public void sendMessage(String topic, String content) {
			MqttMessage message = new MqttMessage (getBytes(content));
			message.Qos = this.qos;
			this.client.Publish (topic, message);
		}

		public byte[] getBytes(String str) {
			byte[] bytes = new byte[str.Length * sizeof(char)];
			System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
			return bytes;
		}

	}
}

