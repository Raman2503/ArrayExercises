using System;
using System.Collections.Generic;
using FunctionCalculations;

namespace Functions
{
	class Program
	{
		static void Main()
		{
			 Implementation1();
			//Implementation2();
		}

		private static void Implementation1()
		{
			// Retrieve input values and perform calculations on inputs
			var inputs = DataManager.GetInputs();
			var square = inputs.CalculateSquare();
			var sin = inputs.CalculateSin();

			// Print inputs and function values on console
			IPrinter consolePrinter = new Printer();
			consolePrinter.Print(inputs,square, sin);

			// Save results to csv file
			IPrinter csvPrinter = new CsvWriter();
			csvPrinter.Print(inputs,square, sin);

			//Calculate area under curve with left point of rectangle as height
			var areaLeftPoint = AreaCalculator.CalculateAreaWithLeftPointAsHeight();
			Console.WriteLine();
			Console.WriteLine($"The area for left point as height is {areaLeftPoint}");

			//Calculate area under curve with right point of rectangle as height
			var areaRightPoint = AreaCalculator.CalculateAreaWithRightPointAsHeight();
			Console.WriteLine();
			Console.WriteLine($"The area for right point as height is {areaRightPoint}");
		}


		interface IPrinter2
		{
			void Print(Dictionary<string, List<double>> allValues);
		}

		private class ConsolePrinter2 : IPrinter2
		{
			public void Print(Dictionary<string, List<double>> allValues)
			{
				
			}
		}

		private class CsvPrinter2 : IPrinter2
		{
			public void Print(Dictionary<string, List<double>> allValues)
			{
				
			}
		}



		private static void Implementation2()
		{
			double initialValue = -2;
			double endValue = 2;
			double step = 0.1;

			var values = CalculateValues(initialValue, endValue, step, x => x);
			var valuesForSquare = CalculateValues(initialValue, endValue, step, x => x * x);
			var valuesForSin = CalculateValues(initialValue, endValue, step, x => Math.Sin(x));

			var allValues = new Dictionary<string, List<double>>()
			{
				{"X", values },
				{"Square", valuesForSquare },
				{"Sin", valuesForSin }
			};

			IPrinter2 printer2 = new ConsolePrinter2();
			printer2.Print(allValues);


			//Calculate area under curve with left point of rectangle as height
			var areaLeftPoint = AreaCalculator.CalculateAreaWithLeftPointAsHeight();
			Console.WriteLine();
			Console.WriteLine($"The area for left point as height is {areaLeftPoint}");

			//Calculate area under curve with right point of rectangle as height
			var areaRightPoint = AreaCalculator.CalculateAreaWithRightPointAsHeight();
			Console.WriteLine();
			Console.WriteLine($"The area for right point as height is {areaRightPoint}");
		}

		private static List<double> CalculateValues(in double initialValue, in double endValue, in double step, Func<double, double> func)
		{
			double currentX = initialValue;
			List<double> results = new List<double>();
			while (currentX < endValue)
			{
				var fx = func(currentX);
				results.Add(fx);

				currentX += step;
			}

			return results;
		}
	}
}
