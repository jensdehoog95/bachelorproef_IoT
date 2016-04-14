using System;
using System.Net.NetworkInformation;

namespace Gigabyke
{
	public class Pinger
	{
		Ping ping;

		public Pinger ()
		{
			this.ping = new Ping ();
		}

		public Boolean testPing(String ip) {
			PingReply pingReply = ping.Send (ip);

			if (pingReply.Status == IPStatus.Success) {
				return true;
			} else {
				return false;
			}
		}
	}
}

