using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingSearchingAlgorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			int arrayLength = 6;

			// Create and print random 1D array of integers
			Console.WriteLine("Random Array of Integers");
			var intArray = ArrayFactory.CreateIntArray(arrayLength);
			intArray.PrintArray();

			// Create and print random 1D array of doubles
			Console.WriteLine("Random Array of Doubles");
			var doubleArray = ArrayFactory.CreateDoubleArray(arrayLength);
			doubleArray.PrintArray();

			Console.WriteLine("Random Array of Strings");
			var stringArray = ArrayFactory.CreateStringArray();
			stringArray.PrintArray();


			// Sort array of integers and print sorted array on console
			Console.WriteLine("Sorted Array of Integers");
			var sortedIntArray = intArray.Sort();
			sortedIntArray.PrintArray();

			// Sort array of doubles and print sorted array on console
			Console.WriteLine("Sorted Array of Doubles");
			var sortedDoubleArray = doubleArray.Sort();
			sortedDoubleArray.PrintArray();

			Console.WriteLine("Sorted Array of Strings");
			var sortedStringArray = stringArray.Sort();
			sortedStringArray.PrintArray();

			// Find random item in sorted arrays and print its index
			var randomNumber = 3;
			var randomString = "Dylan";

			var intIdx = sortedIntArray.FindIndex(randomNumber);
			var doubleIdx = sortedDoubleArray.FindIndex(randomNumber);
			var stringIdx = sortedStringArray.FindIndex(randomString);


			Console.WriteLine($"Number {randomNumber} in array of integers is at index {intIdx}");
			Console.WriteLine($"Number {randomNumber} in array of doubles is at index {doubleIdx}");
			Console.WriteLine($"String {randomString} in array of Strings is at index {stringIdx}");
			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine();

			// Create list of addresses and print them on console.
			List<Address> addresses = new List<Address>()
			{
				new Address("Abbey Road", 10),
				new Address("Liverpool Street", 12),
				new Address("Faraday Road", 58),
				new Address("Am Bahnhof Westend", 13),
				new Address("Rotherstraße", 20),
				new Address("Wieland Road", 42),
				new Address("Faraday Road", 62),
				new Address("Am Bahnhof Westend", 2),
				new Address("Abbey Road", 10),
			};

			Console.WriteLine("List of Addresses:");

			foreach (var address in addresses)
			{
				Console.WriteLine("{0}, {1}", address.Street, address.Number);
			}

			Console.WriteLine();
			var byStreetComparer = new CompareByStreetComparer();

			// Use own Sort method with IComparer.
			var addressesByStreet = ArrayExtensions.Sort(addresses.ToArray(), byStreetComparer);

			//addresses.Sort();

			Console.WriteLine("Addresses Sorted by Street:");
			foreach (var address in addressesByStreet)
			{
				Console.WriteLine("{0}, {1}", address.Street, address.Number);
			}

			Console.WriteLine();

			Console.WriteLine("Addresses in Hash Set:");
			HashSet<Address> addressesSet = new HashSet<Address>(addresses);
			foreach (var address in addressesSet)
			{
				Console.WriteLine("{0}, {1}", address.Street, address.Number);
			}

			var addressToFind = new Address("Wieland Road", 42);

			// Use own Find method with IComparer.
			var addressByStreetIdx = addresses.ToArray().FindIndex(addressToFind, byStreetComparer);
			Console.WriteLine();
			Console.WriteLine($"Address to be found by street is at index {addressByStreetIdx}");

			List<double> doubles = new List<double>()
			{
				242.24698887,
				242.24706745,
				260.2544888,
				269.2021
			};

			var doubleComparer = new DoubleComparer(2);
			var numberSet = new HashSet<double>(doubles, doubleComparer);

			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine();
			Console.WriteLine("Doubles with unique Hash Code");
			foreach (var number in numberSet)
			{
				Console.WriteLine(number);
			}
			Console.WriteLine("------------------------------------------------------------");

			var minAddress = addresses.ToArray().MinBy(addresses.ToArray().First());
			Console.WriteLine("Min By address:");
			Console.WriteLine("{0},{1}", minAddress.Street, minAddress.Number);

			var maxAddress = addresses.ToArray().MaxBy(addresses.ToArray().First());
			Console.WriteLine("Max By address:");
			Console.WriteLine("{0},{1}", maxAddress.Street, maxAddress.Number);
			Console.WriteLine("------------------------------------------------------------");

			int N = 3;
			var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			var result = list.ToArray().TakeEvery(N);

			Console.WriteLine($"Take every {N}rd element");
			foreach (var number in result)
			{
				Console.WriteLine(number);
			}

			Console.WriteLine("------------------------------------------------------------");
			Console.WriteLine("All constructors of Address.cs");

			var addr = typeof(Address);
			PrintAllConstructors(addr);
			Console.WriteLine();
		}

		private static void PrintAllConstructors(Type t)
		{
			var constructors = t.GetConstructors();

			foreach (var c in constructors)
			{
				Console.WriteLine(c);
			}
		}
	}
}
