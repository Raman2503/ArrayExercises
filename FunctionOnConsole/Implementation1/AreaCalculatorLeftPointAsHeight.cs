using System;
using System.Linq;

namespace FunctionCalculations.Implementation1
{
	class AreaCalculatorLeftPointAsHeight : AreaCalculator
	{
		public override double[] CalculateStepValues(double numRectangles)
		{
			double[] stepValues = new double[(int)numRectangles];

			for (int i = 0; i < numRectangles; i++)
			{
				stepValues[i] = startValue + i * stepSize;
			}
			return stepValues;
		}
		
		public override double CalculateArea()
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
	}
}
