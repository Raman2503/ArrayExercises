using System;


namespace ArrayExercises
{
	public class CreateArray
	{
		public int [,] Create2DArray(int rows, int columns)
		{
			Random rand = new Random();

			int[,] matrix = new int[rows, columns];


			for (int i = 0; i < rows; i++)
			{
				Console.WriteLine();

				for (int j = 0; j < columns; j++)
				{
					matrix[i, j] = rand.Next();
				}
			}

			return matrix;
		}
	}
}
