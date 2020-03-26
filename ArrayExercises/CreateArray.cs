using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
	public class CreateArray
	{
		public void Create2DArray(int rows, int columns)
		{
			Random rand = new Random();

			for (int i = 0; i < rows; i++)
			{
				Console.WriteLine();

				for (int j = 0; j < columns; j++)
				{
					int[,] array = new int[rows, columns];

					array[i, j] = rand.Next();
					Console.Write(array[i, j] + " ");
				}
			}
			Console.Read();
		}
	}
}
