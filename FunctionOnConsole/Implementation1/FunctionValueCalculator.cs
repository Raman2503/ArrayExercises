using System;
using System.Collections.Generic;

namespace FunctionCalculations.Implementation1
{
	public static class FunctionValueCalculator
	{
		internal static List<double> Calculate(in double initialValue, in double endValue, in double step, Func<double, double> func)
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
