using System;

namespace ArrayExercises
{
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



			var rndArray = array.Create2DArray(rows, columns);

			printer.PrintArray(rndArray);

			var zeroArray = fill.FillUpperRightWithZeros(rndArray, rows, columns);
			
			printer.PrintArray(zeroArray);

			Console.WriteLine();



			//fill.FillUpperRightWithZeros(array.Create2DArray(rows, columns), rows, columns);

			//fill.FillLowerLeftWithZeros(array.Create2DArray(rows, columns), rows, columns);

		}
	}
}
