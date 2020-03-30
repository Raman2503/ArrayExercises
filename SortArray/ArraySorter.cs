using System;

namespace SortArray
{
	public class ArraySorter
	{
		public int [,] SortArray(int [,] vector)
		{
		for(int outerIndex = 0; outerIndex < vector.Length; outerIndex++)
			for (int innerIndex = 0; innerIndex < vector.Length - outerIndex - 1; innerIndex++)
			{
					if (vector[0, innerIndex] > vector[0, innerIndex + 1])
					{
						int element = vector[0, innerIndex];
						vector[0, innerIndex] = vector[0, innerIndex + 1];
						vector[0, innerIndex + 1] = element;
					}	
			}
			return vector;
		}
	}
}
