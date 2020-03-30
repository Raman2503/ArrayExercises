using System;


namespace SortArray
{
	public class ArrayCreator
	{
		public int[,] Create1DArray(int columns)
		{
			Random rand = new Random();

			int[,] vector = new int[1, columns];

			for (int j = 0; j < columns; j++)
			{
				vector[0, j] = rand.Next(10);
			}
			return vector;
		}
	}
}
