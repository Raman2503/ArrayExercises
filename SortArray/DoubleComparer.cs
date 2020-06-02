using System;
using System.Collections.Generic;

namespace SortingSearchingAlgorithms
{
	internal class DoubleComparer : IEqualityComparer<double>
	{
		int Precision { get; }
		internal DoubleComparer(int precision)
		{
			Precision = precision;
		}

		public bool Equals(double x, double y)
		{
			var roundedX = Math.Round(x, Precision);
			var roundedY = Math.Round(y, Precision);

			return roundedX == roundedY;
		}

		public int GetHashCode(double obj)
		{
			return Math.Round(obj, Precision).GetHashCode();
		}
	}

}
