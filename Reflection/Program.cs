using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Reflection
{
	class Program
	{
		static void Main(string[] args)
		{
			Type city = typeof(City);
			Type aircraft = typeof(Aircraft);

			// Get names of all classes
			Console.WriteLine("Names of all classes:");
			Console.WriteLine(city.Name);
			Console.WriteLine(aircraft.Name);
			Console.WriteLine();

			// Get public fields
			Console.WriteLine($"Public fields:");
			foreach (var field in aircraft.GetFields().Where(m => m.IsPublic))
			{
				Console.WriteLine(field.Name);
			}

			Console.ReadLine();
		}
	}
}
