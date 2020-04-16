using System;

namespace Functions
{
	static class Printer
	{
		public static void Print(this double[] inputs, double[] square, double[] sin)
		{
			string xlabel = "x";
			string y1label = "x^2";
			string y2label = "sin(x)";


			Console.WriteLine($"{xlabel.PadLeft(10)} {y1label.PadLeft(5)} {y2label.PadLeft(10)}");
			Console.WriteLine("-------------------------------------");
			for (int i = 0; i < inputs.Length; i++)
			{
				Console.WriteLine($"{inputs[i].ToString("F3").PadLeft(10)} {square[i].ToString("F4").PadLeft(5)} {sin[i].ToString("F6").PadLeft(10)}");
			}
		}
	}
}
