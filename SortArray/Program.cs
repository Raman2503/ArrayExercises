using System;

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
		}
	}
}
