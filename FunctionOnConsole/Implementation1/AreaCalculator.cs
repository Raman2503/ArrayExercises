using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace FunctionCalculations.Implementation1
{
	abstract class AreaCalculator
	{
		internal static double startValue = 1;
		internal static double endValue = 3;
		internal static double stepSize = 0.0001;

		public static double CalculateNumberOfRectangles()
		{
			var numRectangles = Math.Abs((startValue - endValue) / (stepSize));
			return (int)numRectangles;
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

		public virtual double CalculateArea()
		{
			var numRectangles = Math.Abs(CalculateNumberOfRectangles());
			var width = Math.Abs(CalculateWidth(numRectangles));
			var stepValues = CalculateStepValues(numRectangles);
			var height = CalculateHeight(stepValues);
			double[] areaOfEachRectangle = new double[(int)numRectangles];
			var totalArea = 0.0;

			if (numRectangles != 0)
			{
				for (int i = 0; i < numRectangles; i++)
				{
					areaOfEachRectangle[i] = height[i] * width;

					totalArea = totalArea + areaOfEachRectangle[i];
				}
			}
			return totalArea;
		}

		public abstract double[] CalculateStepValues(double numRectangles);
	}
}
