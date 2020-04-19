using System.Collections.Generic;
using System.IO;

namespace FunctionCalculations.Implementation1
{
	public class CsvWriter:IPrinter
	{
		 public void Print(List<double> inputs, List<double> squareResults, List<double> sinResults)
		{
			var csvFile = "Results.csv";

			using var file = new StreamWriter(csvFile);
			file.WriteLine("x;x^2;sin(x)");

			for (int i = 0; i < inputs.Count; i++)
			{
				file.WriteLine(
					"{0};{1};{2}",
					inputs[i],
					squareResults[i],
					sinResults[i]
				);
			}
		}
	}
}
