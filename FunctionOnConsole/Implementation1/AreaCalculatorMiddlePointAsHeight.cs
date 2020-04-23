using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionCalculations.Implementation1
{
	class AreaCalculatorMiddlePointAsHeight : AreaCalculator
	{
		public override double[] CalculateStepValues(double numRectangles)
		{
			double[] stepValues = new double[(int)numRectangles];

			for (int i = 0; i < numRectangles; i++)
			{
				stepValues[i] = (startValue + 0.5*stepSize) + i * stepSize;  
			}
			return stepValues;
		}
	}
}
