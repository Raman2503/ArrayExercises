using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
	public class CreateArray
	{
		public int [,] Create2DArray(int rows, int columns)
		{
			Random rand = new Random();
			FillWithZeros zeros = new FillWithZeros();
			Console.WriteLine("Random Array");
			
			for (int i = 0; i < rows; i++)
			{
				Console.WriteLine();

				for (int j = 0; j < columns; j++)
				{
					int[,] matrix = new int[rows, columns];

					matrix[i, j] = rand.Next();

					Console.Write(matrix[i, j] + " ");
				}
			}
			int[,] array = new int[rows, columns];
			return array;
		}
	}
}
