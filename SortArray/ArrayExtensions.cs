using System;

namespace SortArray
{
	public static class ArrayExtensions
	{
		public static int [] Sort(this int [] vector)
		{
			for (int outerIndex = 0; outerIndex < vector.Length; outerIndex++)
			{
				for (int innerIndex = 0; innerIndex < vector.Length - outerIndex - 1; innerIndex++)
				{
					if (vector[innerIndex] > vector[innerIndex + 1])
					{
						int element = vector[innerIndex];
						vector[innerIndex] = vector[innerIndex + 1];
						vector[innerIndex + 1] = element;
					}
				}
			}
			return vector;
		}

		public static int FindIndex(this int[] vector, int number)
		{
			int maxIndex = vector.Length - 1;
			int minIndex = 0;
			int indexNotFound = -1;

			while (minIndex <= maxIndex)
			{
				// Check if number is on the left side. If yes, new maxIndex is defined.
				int middleIndex = maxIndex + minIndex / 2;
				if (number < vector[middleIndex])
				{
					maxIndex = middleIndex - 1;
				}
				// Check if number is on the right side. If yes, new minIndex is defined.
				else if (number > vector[middleIndex])
				{
					minIndex = middleIndex + 1;
				}
				// Check if number matches number in the middle of array
				else if (number == vector[middleIndex])
				{
					return middleIndex;
				}
			}
			// If number was not found in array return index -1
			return indexNotFound;
		}

		/// <summary>
		/// This class contains the method for printing 1D arrays on the console.
		/// </summary>
		/// <param name="array"></param>
		public static void PrintArray(this int[] array)

		{
			int columns = array.Length;
			for (int j = 0; j < columns; j++)
			{
				Console.Write(array[j].ToString().PadLeft(5));
			}
			Console.WriteLine();
		}
	}
}
