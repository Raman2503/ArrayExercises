using System;


namespace SortArray
{
	public class ArrayFactory
	{
		public static int[] Create1DArray(int columns)
		{
			Random rand = new Random();

			int[] vector = new int[columns];

			for (int j = 0; j < columns; j++)
			{
				vector[j] = rand.Next(10);
			}
			return vector;
		}
	}
}
