using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
