using System;
using System.Diagnostics.CodeAnalysis;

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
			
			// Sort array of integers and print sorted array on console
			Console.WriteLine("Sorted Array of Integers");
			var sortedIntArray = intArray.Sort();
			sortedIntArray.PrintArray();

			// Sort array of doubles and print sorted array on console
			Console.WriteLine("Sorted Array of Doubles");
			var sortedDoubleArray = doubleArray.Sort();
			sortedDoubleArray.PrintArray();

			// Find random value in sorted arrays and print its index
			var randomNumber = 3;

			var intIdx = sortedIntArray.FindIndex(randomNumber);
			var doubleIdx = sortedDoubleArray.FindIndex(randomNumber);
			
			Console.WriteLine($"Number {randomNumber} in array of integers is at index {intIdx}");
			Console.WriteLine($"Number {randomNumber} in array of doubles is at index {doubleIdx}");
		}
	}
}
