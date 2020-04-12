using System.Linq;

namespace FunctionOnConsole
{
	internal static class DataManager
	{
		internal static readonly double[] Input = Enumerable.Range(-10, 40).Select(i => i * 0.5).ToArray();

		internal static double[] GetInputs()
		{
			return Input;
		}
	}
}
