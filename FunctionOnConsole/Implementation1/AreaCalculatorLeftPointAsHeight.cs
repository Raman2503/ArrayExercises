using System;
using System.Linq;

namespace FunctionCalculations.Implementation1
{
	class AreaCalculatorLeftPointAsHeight : AreaCalculator
	{
		static double[] CalculateStepValuesForLeftPoint(double numRectangles)
		{
			double[] stepValues = new double[(int)numRectangles];

			for (int i = 0; i < numRectangles; i++)
			{
				stepValues[i] = startValue + i * stepSize;
			}
			return stepValues;
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
	}
}
