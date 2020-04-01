using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SortArray
{
	[SuppressMessage("ReSharper", "UnusedParameter.Local")]
	class Program
	{
		static void Main(string[] args)
		{
			int columns = 6;
			
			
			// Create and print random 1D array
			Console.WriteLine("Random 1D Array");

			var rndVector = ArrayFactory.Create1DArray(columns);

			rndVector.PrintArray();

			Console.WriteLine();

			// Sort array and print sorted array on console
			Console.WriteLine("Sorted Array");
			var sortedArray = rndVector.Sort();

			sortedArray.PrintArray();

			// Find random value in sorted array and print its index
			int randomNumber = 3;

			var idx = sortedArray.FindIndex(randomNumber);
			
			Console.WriteLine();
			Console.WriteLine($"Number {randomNumber} is at index {idx}");
		}
	}
}
