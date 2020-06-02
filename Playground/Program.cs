using System;
using System.Collections.Generic;

namespace Playground
{
	class Program
	{
		static IEnumerable<int> GetSomeNumbers()
		{
			Console.WriteLine("We just entered GetSomeNumbers()");

			yield return 7;

			Console.WriteLine("after yield return 7");
			yield return 42;


			Console.WriteLine("after yield return 42");
		}


		static void Main(string[] args)
		{

			foreach (var item in GetSomeNumbers())
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();
			Console.WriteLine();
			{
				IEnumerable<int> enumerable = GetSomeNumbers();
				var enumerator = enumerable.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						var item = enumerator.Current;
						Console.WriteLine(item);
					}
				}
				finally
				{
					enumerator.Dispose();
				}
			}


			Console.WriteLine();
			Console.WriteLine();

			{
			
				IEnumerable<int> enumerable = GetSomeNumbers();
				if (enumerable != null)
				{
					var enumerator1 = enumerable.GetEnumerator();
					var enumerator2 = enumerable.GetEnumerator();

					enumerator1.MoveNext();

					enumerator2.MoveNext();
					enumerator2.MoveNext();

					Console.WriteLine(enumerator1.Current);
					Console.WriteLine(enumerator2.Current);
				}
			}

			return;
			#region Foreach internals

			{
				List<int> list = new List<int>() { 1, 2, 3, 4 };

				foreach (var item in list)
				{
					Console.WriteLine(item);
				}


				var enumerator = list.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						var item = enumerator.Current;
						Console.WriteLine(item);
					}
				}
				finally
				{
					enumerator.Dispose();
				}
			}

			#endregion




			Console.ReadLine();
		}
	}
}
