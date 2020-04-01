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


			FillWithZeros fill = new FillWithZeros();

			Console.WriteLine("Random Array");

			var rndArray = CreateArray.Create2DArray(rows, columns);

			ArrayPrinter.PrintArray(rndArray);

			// Fill upper right with zeros
			var upperRight = fill.FillUpperRightWithZeros(rndArray, rows, columns);

			ArrayPrinter.PrintArray(upperRight);

			Console.WriteLine();

			// Fill upper left with zeros
			var upperLeft = fill.FillUpperLeftWithZeros(rndArray, rows, columns);

			ArrayPrinter.PrintArray(upperLeft);

			Console.WriteLine();

			//Fill lower left with zeros
			var lowerLeft = fill.FillLowerLeftWithZeros(rndArray, rows, columns);

			ArrayPrinter.PrintArray(lowerLeft);

			Console.WriteLine();

			// Fill lower right with zeros
			var lowerRight = fill.FillLowerRightWithZeros(rndArray, rows, columns);

			ArrayPrinter.PrintArray(lowerRight);

			Console.WriteLine();

			//Fill right with zeros
			var right = fill.FillRightWithZeros(rndArray, rows, columns);

			ArrayPrinter.PrintArray(right);

			Console.WriteLine();
		}
	}
}
