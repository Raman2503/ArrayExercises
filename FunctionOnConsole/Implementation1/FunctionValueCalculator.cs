using System;
using System.Collections.Generic;

namespace FunctionCalculations.Implementation1
{
	public static class FunctionValueCalculator
	{
		internal static List<List<double>> CalculateFunctionValues(in double initialValue, in double endValue, in double[] stepValues, Func<double, double> func)
		{
			List<List<double>> allResults = new List<List<double>>();
			const double epsilon = 1e-8;

			foreach (var stepValue in stepValues)
			{
				var currentX = initialValue;
				var result = new List<double>();

				while (Math.Abs(currentX - epsilon) < endValue)
				{
					var fx = func(currentX);
					result.Add(fx);

					currentX += stepValue;
				}
				allResults.Add(result);
			}
			return allResults;
		}

		internal static List<double> CalculateHeight(in double initialValue, in double endValue, in double stepAreaCalculation, Func<double, double> func)
		{
			double currentX = initialValue;
			List<double> results = new List<double>();
			const double epsilon = 1e-8;

			while (Math.Abs(currentX - epsilon) < endValue)
			{
				var fx = func(currentX);
				results.Add(fx);

				currentX += stepAreaCalculation;
			}
			return results;
		}
	}
}
