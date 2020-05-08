using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
	public class Aircraft
	{
		private double GrossWeight { get; set; }
		public double TAS { get; set; }

		public double sonicSpeed;

		private void CalculateMach()
		{
			sonicSpeed = 150.0;
			TAS = 128.0;

			var mach = TAS / sonicSpeed;

			Console.WriteLine($"Mach {mach}");
		}


	}
}
