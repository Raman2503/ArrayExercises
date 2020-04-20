using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionCalculations.Implementation1
{
	class AreaCalculatorMiddlePointAsHeight : AreaCalculator
	{
		static double[] CalculateStepValuesForMiddlePoint(double numRectangles)
		{
			double[] stepValues = new double[(int)numRectangles];

			for (int i = 0; i < numRectangles; i++)
			{
				stepValues[i] = (startValue + 0.5*stepSize) + i * stepSize;  
			}
			return stepValues;
		}

		public static double CalculateAreaWithMiddlePointAsHeight()
		{
			var numRectangles = Math.Abs(CalculateNumberOfRectangles());
			var width = Math.Abs(CalculateWidth(numRectangles));
			var stepValues = CalculateStepValuesForMiddlePoint(numRectangles);
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
