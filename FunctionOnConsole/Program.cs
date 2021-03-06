﻿using FunctionCalculations.Implementation1;
using NLog;
using System;

namespace FunctionCalculations
{
	class Program
	{
		static void Main()
		{
			Implementation1();
			//Implementation2();
		}

		private static readonly Logger ProgramLogger = LogManager.GetLogger("ProgramLogger");

		private static void Implementation1()
		{
			double initialValue = 1;
			double endValue = 3;
			double[] stepsFunctionCalculator = { 0.1, 0.2, 0.5, 1 };

			//Validate step Values for function value calculation and area calculation as well as starting and
			// end value.
			var stepAreaCalculator = AreaCalculator.stepSize;
			//LogManager.DisableLogging();

			try
			{
				ProgramLogger.Info("Starting Function Calculation");
				InputValidation.ValidateStepSize(stepsFunctionCalculator, initialValue, endValue, stepAreaCalculator);

				var inputs = FunctionValueCalculator.CalculateFunctionValues(initialValue, endValue, stepsFunctionCalculator, x => x);
				var square = FunctionValueCalculator.CalculateFunctionValues(initialValue, endValue, stepsFunctionCalculator, x => x * x);
				var sin = FunctionValueCalculator.CalculateFunctionValues(initialValue, endValue, stepsFunctionCalculator, x => Math.Sin(x));

				// Print inputs and function values on console for all step sizes
				IPrinter consolePrinter = new ConsolePrinter();
				consolePrinter.Print(inputs, square, sin, stepsFunctionCalculator);

				// Save results to csv file
				IPrinter csvPrinter = new CsvWriter();
				csvPrinter.Print(inputs, square, sin, stepsFunctionCalculator);

				ProgramLogger.Info("Function Calculation was successful");
			}
			catch (Exception)
			{
				ProgramLogger.Error("Step size was zero. Check inputs");
				Console.WriteLine();
				throw;
			}

			//Calculate area under curve with left point of rectangle as height
			AreaCalculatorLeftPointAsHeight leftPoint = new AreaCalculatorLeftPointAsHeight();

			ProgramLogger.Info("Starting Area Calculator");

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

			ProgramLogger.Info("Area Calculation was successful");
		}


		/*
				interface IPrinter2
				{
					void Print(Dictionary<string, List<double>> allValues);
				}
		*/

		/*
				private class ConsolePrinter2 : IPrinter2
				{
					public void Print(Dictionary<string, List<double>> allValues)
					{

					}
				}
		*/


		/*
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
		*/

		/*
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
		*/
	}
}
