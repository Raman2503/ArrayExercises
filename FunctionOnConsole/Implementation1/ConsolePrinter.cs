using System;
using System.Collections.Generic;

namespace FunctionCalculations.Implementation1
{
	public class ConsolePrinter: IPrinter
	{
		public void Print(List<double> inputs, List<double> square, List<double> sin)
		{
			string xlabel = "x";
			string y1label = "x^2";
			string y2label = "sin(x)";

			Console.WriteLine($"{xlabel.PadLeft(10)} {y1label.PadLeft(10)} {y2label.PadLeft(10)}");
			Console.WriteLine("-------------------------------------");
			for (int i = 0; i < inputs.Count; i++)
			{
				Console.WriteLine($"{inputs[i].ToString("F4").PadLeft(10)} {square[i].ToString("F4").PadLeft(10)} {sin[i].ToString("F6").PadLeft(10)}");
			}
		}
	}
}
