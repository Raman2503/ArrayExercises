using System;
using System.Collections.Generic;

namespace SortingSearchingAlgorithms
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
		/// <param name="element"></param>
		/// <returns></returns>
		public static int FindIndex<T>(this T[] vector, T element) where T : IComparable<T>
		{
			int maxIndex = vector.Length - 1;
			int minIndex = 0;
			int indexNotFound = -1;

			while (minIndex <= maxIndex)
			{
				// Check if element is on the left side. If yes, new maxIndex is defined.
				int middleIndex = maxIndex + minIndex / 2;
				if (element.CompareTo(vector[middleIndex]) < 0)
				{
					maxIndex = middleIndex - 1;
				}
				// Check if element is on the right side. If yes, new minIndex is defined.
				else if (element.CompareTo(vector[middleIndex]) >  0)
				{
					minIndex = middleIndex + 1;
				}
				// Check if element matches element in the middle of array
				else if (element.Equals(vector[middleIndex]))
				{
					return middleIndex;
				}
			}
			// If element was not found in array return index -1
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

		public static int FindIndex<T>(this T[] vector, T element, IComparer<T> comparer) 
		{
			int maxIndex = vector.Length - 1;
			int minIndex = 0;
			int indexNotFound = -1;

			while (minIndex <= maxIndex)
			{
				// Check if element is on the left side. If yes, new maxIndex is defined.
				int middleIndex = maxIndex + minIndex / 2;
				if(comparer.Compare(element,vector[middleIndex]) < 0)
				{
					maxIndex = middleIndex - 1;
				}
				// Check if element is on the right side. If yes, new minIndex is defined.
				else if (comparer.Compare(element, vector[middleIndex]) > 0)
				{
					minIndex = middleIndex + 1;
				}
				// Check if element matches element in the middle of array
				else if (comparer.Compare(element, vector[middleIndex]) == 0)
				{
					return middleIndex;
				}
			}
			// If element was not found in array return index -1
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
