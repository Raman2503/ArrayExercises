﻿using System;

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

			if (newArray.GetLength(0) > newArray.GetLength(1))
			{
				for (int j = 0; j < columns; j++)
				{
					Console.WriteLine();

					for (int i = 0; j <= rows - i -1; i++)
					{
						newArray[i, j] = 0;
					}
				}
			}

			else
			{
				for (int i = 0; i < rows; i++)
				{
					Console.WriteLine();

					for (int j = 0; j <= columns - 1 - i; j++)
					{
						newArray[i, j] = 0;
					}
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
			if (newArray.GetLength(0) > newArray.GetLength(1))
			{
				for (int i = rows - 1; i > 0; i--)
				{
					Console.WriteLine();

					for (int j = columns - i; j < columns  ; j++)
					{
						newArray[i, j] = 0;
					}
				}
			}
			else
			{
				for (int i = newArray.GetLength(0) - 1; i >= 0; i--)
				{
					Console.WriteLine();
					for (int j = newArray.GetLength(1) - i - 1; j < columns; j++)
					{
						newArray[i, j] = 0;
					}
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
			if(newArray.GetLength(0)> newArray.GetLength(1))
			{

				for (int j = 0; j < columns; j++)
				{
						for (int i = j; i < rows; i++)
						{
							newArray[i, j] = 0;
						}
				}
				
			}

			else
			{
				for (int i = 0; i < rows; i++)
				{

					Console.WriteLine();

					for (int j = 0; j <= i; j++)
					{
						newArray[i, j] = 0;

					}

				}
			}
		
			return newArray;
		}
	}
}
