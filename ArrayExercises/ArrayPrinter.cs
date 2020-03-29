using System;


namespace ArrayExercises
{
	public class ArrayPrinter
	{
		/// <summary>
		/// This class contains the method for printing 2D arrays on the console.
		/// </summary>
		/// <param name="array"></param>
		public void PrintArray(int[,] array)

		{
			int rows = array.GetLength(0);
			int columns = array.GetLength((1));

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write("{0,10}",array[i, j] + "\t");
				}

				Console.WriteLine();
			}
		}
	}
}
