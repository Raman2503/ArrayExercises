using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionCalculations.Implementation1
{
	public static class InputValidation
	{
		public static void ValidateStepSize(double step, double startValue, double endValue)
		{
			if(step == 0)
			{
				throw new ArgumentException("Step value must not be zero");
			}

			if(step > endValue - startValue )
			{
				throw new ArgumentException("Step value must not exceed value range");
			}
		}
	}
}
