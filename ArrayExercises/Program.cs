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


			Console.WriteLine("Random Array");

			var rndArray = CreateArray.Create2DArray(rows, columns);

			ArrayPrinter.PrintArray(rndArray);

			// Fill upper right with zeros
			var upperRight = rndArray.FillUpperRightWithZeros(rows, columns);

			ArrayPrinter.PrintArray(upperRight);

			Console.WriteLine();

			// Fill upper left with zeros
			var upperLeft = rndArray.FillUpperLeftWithZeros(rows, columns);

			ArrayPrinter.PrintArray(upperLeft);

			Console.WriteLine();

			//Fill lower left with zeros
			var lowerLeft = rndArray.FillLowerLeftWithZeros(rows, columns);

			ArrayPrinter.PrintArray(lowerLeft);

			Console.WriteLine();

			// Fill lower right with zeros
			var lowerRight = rndArray.FillLowerRightWithZeros(rows, columns);

			ArrayPrinter.PrintArray(lowerRight);

			Console.WriteLine();

			//Fill right with zeros
			var right = rndArray.FillRightWithZeros(rows, columns);

			ArrayPrinter.PrintArray(right);

			Console.WriteLine();
		}
	}
}
