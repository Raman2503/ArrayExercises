using System;

namespace FunctionOnConsole
{
	static class Printer
	{
		public static void Print(this double[] inputs, double[] results)
		{
			string xlabel = "x";
			string ylabel = "f(x)";

			Console.WriteLine($"{xlabel.PadLeft(5)} \t {ylabel.PadLeft(5)}");
			Console.WriteLine("______________");
			for (int i = 0; i < inputs.Length; i++)
			{
				Console.WriteLine($"{inputs[i].ToString().PadLeft(5)} \t {results[i].ToString().PadLeft(5)}");
			}
		}
	}
}
