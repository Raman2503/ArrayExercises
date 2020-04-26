using System;
using System.Linq;

namespace FunctionCalculations.Implementation1
{
	public static class InputValidation
	{
		public static void ValidateStepSize(double[] stepFunctionValue, double initialFunctionValue, double finalFunctionValue, double stepAreaCalculator)
		{
			if (stepFunctionValue.Contains(0) || stepAreaCalculator == 0)
			{
				throw new ArgumentException("Step value must not be zero");
			}

			if (stepFunctionValue.Max() > finalFunctionValue - initialFunctionValue)
			{
				throw new ArgumentException("Step value must not exceed value range");
			}
		}
	}
}
