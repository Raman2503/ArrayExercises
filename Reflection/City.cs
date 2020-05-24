using System;

namespace Reflection
{
	[My]
	public class City
	{
		public double Inhabitants { get; set; } = 1e+6;

		private readonly double area;

		protected double GDP;

		public void DisplayNumberOfInhabitants()
		{
			Console.WriteLine(Inhabitants);
		}

	}
}
