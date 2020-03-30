using System;
using System.Collections.Generic;
using System.Text;

namespace SortArray
{
	class ArrayPrinter1D
	{
		/// <summary>
		/// This class contains the method for printing 1D arrays on the console.
		/// </summary>
		/// <param name="array"></param>
		public void PrintArray(int[,] array)

		{
			int columns = array.GetLength((1));

				for (int j = 0; j < columns; j++)
				{
					Console.Write(array[0,j].ToString().PadLeft(5));
				}
				Console.WriteLine();
		}
	}
}
