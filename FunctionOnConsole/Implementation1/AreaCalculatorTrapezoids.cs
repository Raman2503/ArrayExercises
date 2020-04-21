using System;

namespace FunctionCalculations.Implementation1
{
	class AreaCalculatorTrapezoids : AreaCalculator
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

		public double CalculateAreaRectangles()
		{
			var areaRectangles = 0.0;
			var numRectangles = Math.Abs(CalculateNumberOfRectangles());
			var width = Math.Abs(CalculateWidth(numRectangles));
			var stepValues = CalculateStepValues(numRectangles);
			var height = CalculateHeight(stepValues);
			double[] areaOfEachRectangle = new double[(int)numRectangles];

			if (numRectangles != 0)
			{
				for (int i = 0; i < numRectangles; i++)
				{
					areaOfEachRectangle[i] = height[i] * width;

					areaRectangles = areaRectangles + areaOfEachRectangle[i];
				}
			}
			return areaRectangles;
		}

		public double CalculateAreaTriangles()
		{
			AreaCalculatorRightPointAsHeight rightPoint = new AreaCalculatorRightPointAsHeight();
			var numRectangles = Math.Abs(CalculateNumberOfRectangles());
			var stepValuesLeft = CalculateStepValues(numRectangles);
			var stepValuesRight = rightPoint.CalculateStepValues(numRectangles);
			var heightLeftPoint = CalculateHeight(stepValuesLeft);
			var heightRightpoint = CalculateHeight(stepValuesRight);
			var width = Math.Abs(CalculateWidth(numRectangles));
			double[] areaOfEachTriangle = new double[(int)numRectangles];
			var areaTriangles = 0.0;

			if (numRectangles != 0)
			{
				for (int i = 0; i < numRectangles; i++)
				{
					areaOfEachTriangle[i] = 0.5*width*(heightRightpoint[i]-heightLeftPoint[i]);

					areaTriangles = areaTriangles + areaOfEachTriangle[i];
				}
			}
			return areaTriangles;
		}

		public override double CalculateArea()
		{
			var areaRectangles = CalculateAreaRectangles();
			var areaTriangles = CalculateAreaTriangles();

			var totalArea = areaTriangles + areaRectangles;

			return totalArea;
		}
	}
}
