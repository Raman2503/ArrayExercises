using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
	public class ArrayPrinter
	{
		public void PrintArray(int[,] array)

		{
			int rows = array.GetLength(0);
			int columns = array.GetLength((1));

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write($"{array[i, j]}  ");
				}
				Console.WriteLine();
			}
		}
	}
}
