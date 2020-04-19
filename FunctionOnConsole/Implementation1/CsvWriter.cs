using System.IO;
using FunctionCalculations;

namespace Functions
{
	public class CsvWriter:IPrinter
	{
		 public void Print(double[] inputs, double[] squareResults, double[] sinResults)
		{
			var csvFile = "Results.csv";

			using var file = new StreamWriter(csvFile);
			file.WriteLine("x;x^2;sin(x)");

			for (int i = 0; i < inputs.Length; i++)
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
