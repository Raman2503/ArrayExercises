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
	}
}
