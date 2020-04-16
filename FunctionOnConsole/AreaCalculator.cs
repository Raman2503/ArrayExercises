using System;
using System.Collections.Generic;
using System.Linq;
using Functions;

namespace FunctionCalculations
{
	public static class AreaCalculator
	{
		static double startValue = 1;
		static double endValue = 3;
		static double stepSize = 0.001 ;


		static double CalculateNumberOfRectangles()
		{
			return (startValue - endValue) / (stepSize);
		}

		static double[] CalculateStepValues()
		{
			var numRectangles = Math.Abs(CalculateNumberOfRectangles());
			double[] stepValues = new double[(int)numRectangles];

			for (int i=0; i < numRectangles; i++)
			{
				stepValues[i] = startValue + i*stepSize;
			}
			return stepValues;
		}


		static double CalculateWidth()
		{
			var numRectangle = CalculateNumberOfRectangles();
			return (endValue - startValue) / numRectangle;
		}

		static double[] CalculateHeight()
		{
			var stepValues = CalculateStepValues();

			double[] height = new double[stepValues.Length];

			for (int i = 0; i <= stepValues.Length; i++)
			{
				height = FunctionValueCalculator.CalculateSquare(stepValues);
			}
			return height;
		}



		public static double CalculateAreaWithLeftPointAsHeight()
		{
			var width = Math.Abs(CalculateWidth());
			var height = CalculateHeight();
			var numRectangles = Math.Abs(CalculateNumberOfRectangles());
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
