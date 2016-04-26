using System;

namespace Gigabyke
{
	public class Events
	{
		private int _id;
		private long _milliseconds;
		private double _magnitude;

		public Events (int id, long timeElapsed, double mag)
		{
			this._id = id;
			this._milliseconds = timeElapsed;
			this._magnitude = mag;
		}

		//Get the number of milliseconds that are passed.
		public long getMilliseconds()
		{
			return _milliseconds;
		}

		//Get the ID of the event.
		public double getID()
		{
			return _id;
		}

		//Get the magnitude of the measurement.
		public double getMagnitude()
		{
			return _magnitude;
		}

	}
}
