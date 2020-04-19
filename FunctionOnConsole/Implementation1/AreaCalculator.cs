using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace FunctionCalculations.Implementation1
{
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	abstract class AreaCalculator
	{
		internal static double startValue = 1;
		internal static double endValue = 3;
		internal static double stepSize = 0.005;

		public static double CalculateNumberOfRectangles()
		{
			var numRectangles = Math.Abs((startValue - endValue) / (stepSize));
			return Math.Round(numRectangles);
		}
		
		public static double CalculateWidth(double numRectangle)
		{
			return (endValue - startValue) / numRectangle;
		}

		public static double[] CalculateHeight(double[] stepValues)
		{
			var height = FunctionValueCalculator.Calculate(stepValues.First(), stepValues.Last(), stepSize, x => x * x).ToArray();

			return height;
		}
	}
}
