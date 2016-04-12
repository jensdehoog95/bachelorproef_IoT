using System;

namespace Gigabyke
{
	public class Events
	{
		private int _id;
		private double _milliseconds;

		public Events (int id,double timeElapsed)
		{
			this._id = id;
			this._milliseconds = timeElapsed;
		}



	}
}

