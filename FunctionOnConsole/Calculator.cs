using System.Linq;

namespace FunctionOnConsole
{
	public static class Calculator
	{
		public static double[] CalculateFunctionValue(this double[] inputs)
		{
			var functionValues = inputs.Select(x => x*x).ToArray();

			return functionValues;
		}
	}
}
