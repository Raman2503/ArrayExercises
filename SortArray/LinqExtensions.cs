using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingSearchingAlgorithms
{
	internal static class LinqExtensions
	{

		public static T MinBy<T>(this IEnumerable<T> collection, T refItem) where T : IComparable<T>
		{
			foreach (var address in collection)
			{
				if (address.CompareTo(refItem) < 0)
				{
					refItem = address;
				}
			}
			return refItem;
		}

		public static T MaxBy<T>(this IEnumerable<T> collection, T refItem) where T : IComparable<T>
		{
			foreach (var address in collection)
			{
				if (address.CompareTo(refItem) > 0)
				{
					refItem = address;
				}
			}
			return refItem;
		}

		public static IEnumerable<T> TakeEvery<T>(this IEnumerable<T> collection, int N)
		{
			if (N != 0)
			{
				var counter = 1;
				foreach (var c in collection)
				{

					if (counter % N == 0)
					{
						yield return c;
					}

					counter ++;
				}
			}
			
			else
			{
				Console.WriteLine("Oooops, N was zero.");
			}
		}

		public static IEnumerable<T> MySkipUntil<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			var counter = 0;

			foreach (var item in collection)
			{    
				if(predicate(item))
					counter++;
				if(counter > 1)
					yield return item;

			}
		}

	}
}
