using System;
using System.Diagnostics.CodeAnalysis;

namespace FillTrianglesWithZeros
{
	[SuppressMessage("ReSharper", "UnusedParameter.Local")]
	class Program
	{
		static void Main(string[] args)
		{
			int rows = 5;
			int columns = 4;


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
			var upperLeft = fill.FillUpperLeftWithZeros(rndArray, rows, columns);

			printer.PrintArray(upperLeft);

			Console.WriteLine();

			//Fill lower left with zeros
			var lowerLeft = fill.FillLowerLeftWithZeros(rndArray, rows, columns);

			printer.PrintArray(lowerLeft);

			Console.WriteLine();

			// Fill lower right with zeros
			var lowerRight = fill.FillLowerRightWithZeros(rndArray, rows, columns);

			printer.PrintArray(lowerRight);

			Console.WriteLine();

			//Fill right with zeros
			var right = fill.FillRightWithZeros(rndArray, rows, columns);

			printer.PrintArray(right);

			Console.WriteLine();
		}
	}
}
