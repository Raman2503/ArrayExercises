using FunctionCalculations;

namespace Functions
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

			//Calculate area under curve with left point of rectangle as height
			var areaLeftPoint = AreaCalculator.CalculateAreaWithLeftPointAsHeight();
			System.Console.WriteLine();
			System.Console.WriteLine($"The area for left point as height is {areaLeftPoint}");

			//Calculate area under curve with right point of rectangle as height
			var areaRightPoint = AreaCalculator.CalculateAreaWithRightPointAsHeight();
			System.Console.WriteLine();
			System.Console.WriteLine($"The area for right point as height is {areaRightPoint}");
		}
	}
}
