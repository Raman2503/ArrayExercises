using System;
using System.Collections.Generic;
using System.Text;

namespace SortArray
{
	public class NumberFInder
	{
		public int FindIndex(int[,] vector, int number)
		{
			int maxIndex = vector.GetLength(1)-1;
			int minIndex = 0;
			int indxNotFound = -1;

			while (minIndex <= maxIndex)
			{
				int middleIndex = maxIndex + minIndex / 2;
				if (number < vector[0,middleIndex])
				{
					maxIndex = middleIndex - 1;
				}
				else if(number > vector[0, middleIndex])
				{
					minIndex = middleIndex + 1;
				}
				else if (number == vector[0, middleIndex])
				{
					return middleIndex;
				}

			}
			return indxNotFound;
		}
	}
}
