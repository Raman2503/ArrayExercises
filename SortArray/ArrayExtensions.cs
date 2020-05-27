using System;
using System.Collections;
using System.Collections.Generic;

namespace SortArray
{
	public static class ArrayExtensions 
	{
		/// <summary>
		/// Sorts items in random array in ascending order.
		/// </summary>
		/// <param name="vector"></param>
		/// <returns></returns>
		public static T [] Sort<T>(this T [] vector) where T: IComparable<T>
		{
			for (int outerIndex = 0; outerIndex < vector.Length; outerIndex++)
			{
				for (int innerIndex = 0; innerIndex < vector.Length - outerIndex - 1; innerIndex++)
				{
					if (vector[innerIndex].CompareTo(vector[innerIndex + 1]) > 0)
					{
						T element = vector[innerIndex];
						vector[innerIndex] = vector[innerIndex + 1];
						vector[innerIndex + 1] = element;
					}
				}
			}
			return vector;
		}

		/// <summary>
		/// Find index of an item in the array using Binary search algorithm.
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="number"></param>
		/// <returns></returns>
		public static int FindIndex<T>(this T[] vector, T number) where T : IComparable<T>
		{
			int maxIndex = vector.Length - 1;
			int minIndex = 0;
			int indexNotFound = -1;

			while (minIndex <= maxIndex)
			{
				// Check if number is on the left side. If yes, new maxIndex is defined.
				int middleIndex = maxIndex + minIndex / 2;
				if (number.CompareTo(vector[middleIndex]) < 0)
				{
					maxIndex = middleIndex - 1;
				}
				// Check if number is on the right side. If yes, new minIndex is defined.
				else if (number.CompareTo(vector[middleIndex]) >  0)
				{
					minIndex = middleIndex + 1;
				}
				// Check if number matches number in the middle of array
				else if (number.Equals(vector[middleIndex]))
				{
					return middleIndex;
				}
			}
			// If number was not found in array return index -1
			return indexNotFound;
		}


		public static T[] Sort<T>(this T[] vector, IComparer<T> comparer) 
		{
			for (int outerIndex = 0; outerIndex < vector.Length; outerIndex++)
			{
				for (int innerIndex = 0; innerIndex < vector.Length - outerIndex - 1; innerIndex++)
				{
					if (comparer.Compare(vector[innerIndex], vector[innerIndex + 1]) > 0)
					{
						T element = vector[innerIndex];
						vector[innerIndex] = vector[innerIndex + 1];
						vector[innerIndex + 1] = element;
					}
				}
			}
			return vector;
		}

		public static int FindIndex<T>(this T[] vector, T number, IComparer<T> comparer) where T : IComparable<T>
		{
			int maxIndex = vector.Length - 1;
			int minIndex = 0;
			int indexNotFound = -1;

			while (minIndex <= maxIndex)
			{
				// Check if number is on the left side. If yes, new maxIndex is defined.
				int middleIndex = maxIndex + minIndex / 2;
				if(comparer.Compare(number,vector[middleIndex]) < 0)
				{
					maxIndex = middleIndex - 1;
				}
				// Check if number is on the right side. If yes, new minIndex is defined.
				else if (comparer.Compare(number, vector[middleIndex]) > 0)
				{
					minIndex = middleIndex + 1;
				}
				// Check if number matches number in the middle of array
				else if (comparer.Compare(number, vector[middleIndex]) == 0)
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
			public static void PrintArray<T>(this T[] array)

		{
			int columns = array.Length;
			for (int j = 0; j < columns; j++)
			{
				Console.WriteLine($"{array[j].ToString().PadLeft(0)} \t");
			}
			Console.WriteLine();
		}
	}
}
