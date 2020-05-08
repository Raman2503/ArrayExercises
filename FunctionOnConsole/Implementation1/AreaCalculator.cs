using NLog;
using System;
using System.Linq;

// ReSharper disable All

namespace FunctionCalculations.Implementation1
{
	abstract class AreaCalculator
	{
		internal static double startValue = 1;
		internal static double endValue = 3;
		internal static double stepSize = 0.0001;

		private static readonly Logger AreaCalculatorLogger = LogManager.GetLogger("AreaCalculatorLogger");

		//LogManager.DisableLogging();

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
			var height = FunctionValueCalculator.CalculateHeight(stepValues.First(), stepValues.Last(), stepSize, x => x * x).ToArray();

			return height;
		}

		public virtual double CalculateArea()
		{
			var numRectangles = Math.Abs(CalculateNumberOfRectangles());
			var width = Math.Abs(CalculateWidth(numRectangles));
			var stepValues = CalculateStepValues(numRectangles);
			var height = CalculateHeight(stepValues);

			foreach (var h in height)
			{
				AreaCalculatorLogger.Info(h.ToString);
			}

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

			AreaCalculatorLogger.Info($"Total area: {totalArea}");

			return totalArea;
		}

		public abstract double[] CalculateStepValues(double numRectangles);
	}
}
