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

		public int[,] FillUpperLeftWithZeros(int[,] matrix, int rows, int columns)
		{
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Upper Left");

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
			for (int i = 0; i < rows ; i++)
			{
				Console.WriteLine();

				for (int j = 0; j <= columns-i-1  ; j++)
				{
					newArray[i, j] = 0;
				}
			}
			return newArray;
		}

		public int[,] FillLowerRightWithZeros(int[,] matrix, int rows, int columns)
		{
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Lower Right");

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
			for (int i = 2; i >= 0 ; i--)
			{
				Console.WriteLine();

				for (int j = rows - i -1; j < columns; j++)
				{
					newArray[i, j] = 0;
				}
			}
			return newArray;

		}

		public int [,] FillLowerLeftWithZeros(int[,] matrix, int rows, int columns)
		{
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("Lower Left");

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

				for (int j = 0; j <= i; j++)
				{
					newArray[i, j] = 0;
				}
			}
			return newArray;
		}
	}
}
