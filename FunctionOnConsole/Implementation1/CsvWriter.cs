using System.Collections.Generic;
using System.IO;

namespace FunctionCalculations.Implementation1
{
	public class CsvWriter : IPrinter
	{
		public void Print(List<List<double>> inputs, List<List<double>> squares, List<List<double>> sinResults, double[] stepValues)
		{
			var csvFile = "Results.csv";

			using var file = new StreamWriter(csvFile);

			var stepCount = 0;

			foreach (var input in inputs)
			{
				file.WriteLine($"Step Size: {stepValues[stepCount]}");
				file.WriteLine("x;x^2;sin(x)");

				for (int i = 0; i < input.Count; i++)
				{
					file.WriteLine(
						"{0};{1};{2}",
						input[i],
						squares[stepCount][i],
						sinResults[stepCount][i]
					);
				}
				file.WriteLine();
				stepCount++;
			}
		}
	}
}
