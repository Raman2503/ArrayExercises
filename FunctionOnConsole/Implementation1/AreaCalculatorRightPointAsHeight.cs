using System;
using System.Linq;

namespace FunctionCalculations.Implementation1
{
	class AreaCalculatorRightPointAsHeight : AreaCalculator
	{
		static double[] CalculateStepValuesForRightPoint(double numRectangles)
		{
			double[] stepValues = new double[(int)numRectangles];

			for (int i = 0; i < numRectangles; i++)
			{
				stepValues[i] = startValue + (i + 1) * stepSize;
			}
			return stepValues;
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
