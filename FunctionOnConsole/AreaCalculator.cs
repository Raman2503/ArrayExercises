using System;
using System.Collections.Generic;
using System.Linq;
using Functions;

namespace FunctionCalculations
{
	public static class AreaCalculator
	{
		static readonly double startValue = 1;
		static readonly double endValue = 3;
		static readonly double stepSize = 0.005 ;


		static double CalculateNumberOfRectangles()
		{
			var numRectangles = Math.Abs((startValue - endValue) / (stepSize));
			return Math.Round(numRectangles);
		}

		static double[] CalculateStepValuesForLeftPoint(double numRectangles)
		{
			double[] stepValues = new double[(int)numRectangles];

			for (int i=0; i < numRectangles; i++)
			{
				stepValues[i] = startValue + i*stepSize;
			}
			return stepValues;
		}

		static double[] CalculateStepValuesForRightPoint(double numRectangles)
		{
			double[] stepValues = new double[(int)numRectangles];

			for (int i = 0; i < numRectangles; i++)
			{
				stepValues[i] = startValue + (i+1) * stepSize;
			}
			return stepValues;
		}


		static double CalculateWidth(double numRectangle)
		{
			return (endValue - startValue) / numRectangle;
		}

		static double[] CalculateHeight(double[] stepValues)
		{
			double[] height = new double[stepValues.Length];

			for (int i = 0; i <= stepValues.Length; i++)
			{
				height = FunctionValueCalculator.CalculateSquare(stepValues);
			}
			return height;
		}

	

		public static double CalculateAreaWithLeftPointAsHeight()
		{
			var numRectangles = Math.Abs(CalculateNumberOfRectangles());
			var width = Math.Abs(CalculateWidth(numRectangles));
			var stepValues = CalculateStepValuesForLeftPoint(numRectangles);
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

		public static double CalculateAreaWithRightPointAsHeight()
		{
			var numRectangles = Math.Abs(CalculateNumberOfRectangles());
			var width = Math.Abs(CalculateWidth(numRectangles));
			var stepValues = CalculateStepValuesForRightPoint(numRectangles);
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
	}
}
