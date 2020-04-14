namespace FunctionOnConsole
{
	class Program
	{
		static void Main()
		{
			// Retrieve input values and perform calculations on inputs
			var inputs = DataManager.GetInputs();
			var square = inputs.CalculateSquare();
			var sin = inputs.CalculateSin();

			// Print inputs and function values on console
			inputs.Print(square, sin);

			// Save results to csv file
			CsvWriter.SaveToCsv(inputs,square,sin);
		}
	}
}
