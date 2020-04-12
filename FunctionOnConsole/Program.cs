namespace FunctionOnConsole
{
	class Program
	{
		static void Main()
		{
			// Retrieve input values and perform calculations on inputs
			var inputs = DataManager.GetInputs();
			var results = inputs.CalculateFunctionValue();

			// Print inputs and function values on console
			inputs.Print(results);

			// Save results to csv file
			CsvWriter.SaveToCsv(inputs,results);
		}
	}
}
