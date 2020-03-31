using System;
// ReSharper disable All

namespace SortArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int columns = 6;

			ArrayCreator creator = new ArrayCreator();

			ArrayPrinter1D printer = new ArrayPrinter1D();

			ArraySorter sorter = new ArraySorter();

			
			// Create and print random 1D array
			Console.WriteLine("Random 1D Array");

			var rndVector = creator.Create1DArray(columns);

			printer.PrintArray(rndVector);

			Console.WriteLine();

			// Sort array and print sorted array on console
			Console.WriteLine("Sorted Array");
			var sortedArray = sorter.SortArray(rndVector);

			printer.PrintArray(sortedArray);


			// Find random value in sorted array and print its index
			int randomNumber = 3;
			NumberFInder finder = new NumberFInder();

			var idx = finder.FindIndex(sortedArray, randomNumber);

			Console.WriteLine();
			Console.WriteLine($"Number is at index {idx}");
		}
	}
}
