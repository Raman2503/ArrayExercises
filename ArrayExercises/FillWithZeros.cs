using System;

namespace ArrayExercises
{
	public class FillWithZeros
	{
		public void FillUpperRightWithZeros(int[,] matrix, int rows, int columns)
		{
			
		}

		public void FillUpperLeftWithZeros(int[,] matrix, int rows, int columns)
		{
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Upper Left");

			for (int i = 0; i < rows; i++)
			{
				Console.WriteLine();

				for (int j = i; j < columns; j++)
				{
					matrix[i, j] = 0;

					Console.Write(matrix[i, j] +" ");
				}
			}
			Console.ReadLine();
		}

		public void FillLowerRightWithZeros(int[,] array)
		{ }

		public int [,] FillLowerLeftWithZeros(int[,] matrix, int rows, int columns)
		{
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Lower Left");

			for (int i = 0; i < rows; i++)
			{
				Console.WriteLine();

				for (int j = 0; j <= i; j++)
				{
					int[,] lowerLeft = new int[rows, columns];

					lowerLeft[i, j] = 0;

					Console.Write(lowerLeft[i, j] + " ");
				}
			}
			Console.ReadLine();

			int[,] array = new int[rows, columns];
			return array;
		}

	}
}
