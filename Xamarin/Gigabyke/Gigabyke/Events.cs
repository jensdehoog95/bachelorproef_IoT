<<<<<<< HEAD
﻿using System;

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

=======
﻿using System;

namespace Gigabyke
{
	public class Events
	{
		private int _id;
		private double _milliseconds;
		private double _magnitude;

		public Events (int id, double timeElapsed, double mag)
		{
			this._id = id;
			this._milliseconds = timeElapsed;
			this._magnitude = mag;
		}

		public double getMilliseconds()
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

>>>>>>> 04ec3ff0f979e8ef6ff253790fbc271fa875604c
