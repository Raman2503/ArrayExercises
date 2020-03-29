using System;
using System.Diagnostics.CodeAnalysis;

namespace ArrayExercises
{
	[SuppressMessage("ReSharper", "UnusedParameter.Local")]
	class Program
	{
		static void Main(string[] args)
		{
			int rows = 3;
			int columns = 3;


			//Console.WriteLine("Insert number of rows");

			//rows = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("Insert number of columns");

			//columns = Convert.ToInt32(Console.ReadLine());

			CreateArray array = new CreateArray();

			ArrayPrinter printer = new ArrayPrinter();

			FillWithZeros fill = new FillWithZeros();


			Console.WriteLine("Random Array");

			var rndArray = array.Create2DArray(rows, columns);

			printer.PrintArray(rndArray);

			// Fill upper right with zeros
			var upperRight = fill.FillUpperRightWithZeros(rndArray, rows, columns);

			printer.PrintArray(upperRight);

			Console.WriteLine();

			// Fill upper left with zeros
			var upperLeft = fill.FillUpperLeftWithZeros(array.Create2DArray(rows, columns), rows, columns);

			printer.PrintArray(upperLeft);

			Console.WriteLine();

			//Fill lower left with zeros
			var lowerLeft = fill.FillLowerLeftWithZeros(array.Create2DArray(rows, columns), rows, columns);

			printer.PrintArray(lowerLeft);

			Console.WriteLine();

			// Fill lower right with zeros
			var lowerRight = fill.FillLowerRightWithZeros(array.Create2DArray(rows, columns), rows, columns);

			printer.PrintArray(lowerRight);

			Console.WriteLine();

			//Fill right with zeros
			var right = fill.FillRightWithZeros(array.Create2DArray(rows, columns), rows, columns);

			printer.PrintArray(right);

			Console.WriteLine();
		}
	}
}
