using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SortArray
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
			Console.WriteLine("-------------------------------------------------");


			// Create list of addresses and print them on console.
			List<Address> adresses = new List<Address>()
			{
				new Address("Abbey Road", 10),
				new Address("Liverpool Street", 12),
				new Address("Faraday Road", 58),
				new Address("Am Bahnhof Westend", 13),
				new Address("Rotherstraße", 20),
				new Address("Wieland Road", 42)
			};

			Console.WriteLine("List of Addresses:");

			foreach (var address in adresses)
			{
				Console.WriteLine("{0}, {1}", address.Street, address.Number);
			}

			Console.WriteLine();
			var byStreetComparer = new CompareByStreetComparer();
			var addressesByStreet = ArrayExtensions.Sort(adresses.ToArray(), byStreetComparer);

			Console.WriteLine("Addresses Sorted by Street:");
			foreach (var address in addressesByStreet)
			{
				Console.WriteLine("{0}, {1}", address.Street, address.Number);
			}

			var addressToFind = adresses[2];

			var addressByStreetIdx = addressesByStreet.ToArray().FindIndex(addressToFind, byStreetComparer);
			Console.WriteLine();

			Console.WriteLine($"Address to be found by street is at index {addressByStreetIdx}");
		}
	}
}
