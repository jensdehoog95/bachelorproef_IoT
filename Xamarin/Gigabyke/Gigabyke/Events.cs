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

		public long getMilliseconds()
		{
			return _milliseconds;
		}

		public double getID()
		{
			return _id;
		}

		public double getMagnitude()
		{
			return _magnitude;
		}

	}
}
