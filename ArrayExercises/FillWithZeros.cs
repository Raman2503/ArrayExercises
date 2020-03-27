using System;

namespace ArrayExercises
{
	public class FillWithZeros
	{
		public int [,] FillUpperRightWithZeros(int[,] matrix, int rows, int columns)
		{
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Upper Right");

			int[,] newArray = new int[rows, columns];

			// Creating copy of random matrix
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					newArray[i, j] = matrix[i, j];
				}
			}

			// Filling array with zeros
			for (int i = 0; i < rows; i++)
			{
				Console.WriteLine();

				for (int j = i; j < columns; j++)
				{
					newArray[i, j] = 0;
				}
			}
			return newArray;
		}

		public void FillUpperLeftWithZeros(int[,] matrix, int rows, int columns)
		{
			

		}

		public void FillLowerRightWithZeros(int[,] array)
		{ }

		public int [,] FillLowerLeftWithZeros(int[,] matrix, int rows, int columns)
		{
			Console.WriteLine();

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
