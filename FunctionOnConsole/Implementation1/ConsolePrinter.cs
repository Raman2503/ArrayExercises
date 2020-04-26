using System;
using System.Collections.Generic;

namespace FunctionCalculations.Implementation1
{
	public class ConsolePrinter : IPrinter
	{
		public void Print(List<List<double>> inputs, List<List<double>> squares, List<List<double>> sin,
			double[] stepValues)
		{
			string xlabel = "X";
			string ySquares = "X^2";
			string ySin = "sin(X)";

			var stepCount = 0;

			foreach (var input in inputs)
			{
				Console.WriteLine($"Step Size: {stepValues[stepCount]}");
				Console.WriteLine("---------------------");
				Console.WriteLine($"{xlabel.PadLeft(5)} {ySquares.PadLeft(8)} {ySin.PadLeft(8)}");

				for (int i = 0; i < input.Count; i++)
				{
					Console.WriteLine($"{input[i].ToString("F3").PadLeft(5)} " +
									  $"{squares[stepCount][i].ToString("F3").PadLeft(8)}" +
									  $"{sin[stepCount][i].ToString("F3").PadLeft(8)}");
				}

				Console.WriteLine();
				stepCount++;
			}
		}
	}
}

