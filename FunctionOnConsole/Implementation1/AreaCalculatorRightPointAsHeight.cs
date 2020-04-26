namespace FunctionCalculations.Implementation1
{
	class AreaCalculatorRightPointAsHeight : AreaCalculator
	{
		public override double[] CalculateStepValues(double numRectangles)
		{
			double[] stepValues = new double[(int)numRectangles];

			for (int i = 0; i < numRectangles; i++)
			{
				stepValues[i] = (startValue + stepSize) + i * stepSize;
			}
			return stepValues;
		}
	}
}
