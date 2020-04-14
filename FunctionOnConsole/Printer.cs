using System;

namespace FunctionOnConsole
{
	static class Printer
	{
		public static void Print(this double[] inputs, double[] square, double[] sin)
		{
			string xlabel = "x";
			string y1label = "x^2";
			string y2label = "sin(x)";

			Console.WriteLine($"{xlabel.PadLeft(5)} {y1label.PadLeft(8)} {y2label.PadLeft(20)}");
			Console.WriteLine("-------------------------------------");
			for (int i = 0; i < inputs.Length; i++)
			{
				Console.WriteLine($"{inputs[i].ToString().PadLeft(5)} {square[i].ToString().PadLeft(8)} {sin[i].ToString().PadLeft(20)}");
			}
		}
	}
}
