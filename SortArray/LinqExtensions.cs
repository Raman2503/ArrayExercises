using System;

namespace SortingSearchingAlgorithms
{
	internal static class LinqExtensions
	{

		public static T MinBy<T>(this T[] array, T refItem) where T : IComparable<T>
		{
			foreach (var address in array)
			{
				if (address.CompareTo(refItem) < 0)
				{
					refItem = address;
				}
			}
			return refItem;
		}

		public static T MaxBy<T>(this T[] array, T refItem) where T : IComparable<T>
		{
			foreach (var address in array)
			{
				if (address.CompareTo(refItem) > 0)
				{
					refItem = address;
				}
			}
			return refItem;
		}

		public static T[] TakeEvery<T>(this T[] array, int N)
		{
			if (N != 0)
			{
				var dim = array.Length / N;
				var result = new T[dim];
				int i = 0;

				for (int index = N - 1; index < array.Length; index += N)
				{
					result[i] = array[index];
					i++;
				}

				return result;
			}
			
			else
			{
				Console.WriteLine("Oooops, N was zero.");
				return new T[]{};
			}
		}
	}
}
