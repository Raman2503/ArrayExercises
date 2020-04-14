using System;
using System.Linq;

namespace FunctionOnConsole
{
	public static class Calculator
	{
		public static double[] CalculateSquare(this double[] inputs)
		{
			var square = inputs.Select(x => x*x).ToArray();

			return square;
		}

		public static double[] CalculateSin(this double[] inputs)
		{
			var sin = inputs.Select(Math.Sin).ToArray();

			return sin;
		}
	}
}
