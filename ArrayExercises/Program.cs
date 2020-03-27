using System;

namespace ArrayExercises
{
	class Program
	{
		static void Main(string[] args)
		{
			int rows = 2;
			int columns = 2;


			//Console.WriteLine("Insert number of rows");

			//rows = Convert.ToInt32(Console.ReadLine());
			
			//Console.WriteLine("Insert number of columns");

			//columns = Convert.ToInt32(Console.ReadLine());

			CreateArray array = new CreateArray();

			var rndArray = array.Create2DArray(rows, columns);

			FillWithZeros fill = new FillWithZeros();
			fill.FillUpperLeftWithZeros(rndArray, rows, columns);

			//fill.FillUpperRightWithZeros(array.Create2DArray(rows, columns), rows, columns);

			//fill.FillLowerLeftWithZeros(array.Create2DArray(rows, columns), rows, columns);

		}
	}
}
