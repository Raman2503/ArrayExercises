using System.Collections.Generic;

namespace FunctionCalculations.Implementation1
{
	interface IPrinter
	{
		void Print(List<List<double>> inputs, List<List<double>> squares, List<List<double>> sin, double[] stepValues);
	}
}
