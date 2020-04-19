using System;
using FunctionCalculations;

namespace Functions
{
	public class Printer: IPrinter
	{
		public void Print(double[] inputs, double[] square, double[] sin)
		{
			string xlabel = "x";
			string y1label = "x^2";
			string y2label = "sin(x)";

			Console.WriteLine($"{xlabel.PadLeft(10)} {y1label.PadLeft(10)} {y2label.PadLeft(10)}");
			Console.WriteLine("-------------------------------------");
			for (int i = 0; i < inputs.Length; i++)
			{
				Console.WriteLine($"{inputs[i]:N10} {square[i].ToString("F4").PadLeft(10)} {sin[i].ToString("F6").PadLeft(10)}");
			}
		}
	}
}
