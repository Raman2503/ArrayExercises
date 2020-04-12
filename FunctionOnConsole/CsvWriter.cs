using System.IO;

namespace FunctionOnConsole
{
	public static class CsvWriter
	{
		 public static void SaveToCsv(double[] inputs, double[] results)
		{
			Directory.SetCurrentDirectory("D:/tmp");
			var csvFile = $"{Directory.GetCurrentDirectory()}/Results.csv";

			using var file = new StreamWriter(csvFile);
			file.WriteLine("x;f(x)");

			for (int i = 0; i < inputs.Length; i++)
			{
				file.WriteLine(
					"{0};{1}",
					inputs[i],
					results[i]
				);
			}
		}
	}
}
