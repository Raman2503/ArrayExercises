using FunctionCalculations.Implementation1;
using System;
using System.Collections.Generic;

namespace FunctionCalculations
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
			double initialValue = 1;
			double endValue = 3;
			double step = 0.1;

			InputValidation.ValidateStepSize(step, initialValue, endValue);

			var inputs = FunctionValueCalculator.Calculate(initialValue, endValue, step, x => x);
			var square = FunctionValueCalculator.Calculate(initialValue, endValue, step, x => x * x);
			var sin = FunctionValueCalculator.Calculate(initialValue, endValue, step, x => Math.Sin(x));

			// Print inputs and function values on console
			IPrinter consolePrinter = new ConsolePrinter();
			consolePrinter.Print(inputs, square, sin);

			// Save results to csv file
			IPrinter csvPrinter = new CsvWriter();
			csvPrinter.Print(inputs, square, sin);

			//Calculate area under curve with left point of rectangle as height
			AreaCalculatorLeftPointAsHeight leftPoint = new AreaCalculatorLeftPointAsHeight();

			try
			{
				var areaLeftPoint = leftPoint.CalculateArea();
				Console.WriteLine();
				Console.WriteLine($"The area for left point as height is {areaLeftPoint}");

				//Calculate area under curve with right point of rectangle as height
				AreaCalculatorRightPointAsHeight rightPoint = new AreaCalculatorRightPointAsHeight();
				var areaRightPoint = rightPoint.CalculateArea();
				Console.WriteLine();
				Console.WriteLine($"The area for right point as height is {areaRightPoint}");

				//Calculate area under curve with middle point of rectangle as height
				AreaCalculatorMiddlePointAsHeight middlePoint = new AreaCalculatorMiddlePointAsHeight();
				var areaMiddlePoint = middlePoint.CalculateArea();
				Console.WriteLine();
				Console.WriteLine($"The area for middle point as height is {areaMiddlePoint}");

				//Calculate area under curve with trapezoids
				AreaCalculatorTrapezoids trapezoids = new AreaCalculatorTrapezoids();
				var areaTrapezoids = trapezoids.CalculateArea();
				Console.WriteLine();
				Console.WriteLine($"The area approximated with trapezoids is {areaTrapezoids}");

				//Print number of iterations performed for area calculation
				var numRectangles = AreaCalculator.CalculateNumberOfRectangles();
				Console.WriteLine();
				Console.WriteLine($"Iteration count: {numRectangles}");
			}
			catch (Exception e)
			{
				Console.WriteLine();
				Console.WriteLine(e.Message);
			}
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


			////Calculate area under curve with left point of rectangle as height
			//var areaLeftPoint = AreaCalculatorLeftPointAsHeight.CalculateAreaWithLeftPointAsHeight();
			//Console.WriteLine();
			//Console.WriteLine($"The area for left point as height is {areaLeftPoint}");

			////Calculate area under curve with right point of rectangle as height
			//var areaRightPoint = AreaCalculatorRightPointAsHeight.CalculateAreaWithRightPointAsHeight();
			//Console.WriteLine();
			//Console.WriteLine($"The area for right point as height is {areaRightPoint}");
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
