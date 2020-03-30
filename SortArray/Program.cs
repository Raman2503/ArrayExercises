using System;

namespace SortArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int columns = 6;

			ArrayCreator ac = new ArrayCreator();

			ArrayPrinter1D printer = new ArrayPrinter1D();

			ArraySorter sorter = new ArraySorter();

			
			// Create and print random 1D array
			Console.WriteLine("Random 1D Array");

			var rndVector = ac.Create1DArray(columns);

			printer.PrintArray(rndVector);


			// Sort array and print sorted array on console
			Console.WriteLine("Sorted Array");

			var sortedArray = sorter.SortArray(rndVector);

			printer.PrintArray(sortedArray);
		}
	}
}
