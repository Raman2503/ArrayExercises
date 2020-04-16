using System.Linq;

namespace Functions
{
	internal static class DataManager
	{
		//internal static double stepsize = 0.003;
		internal static readonly double[] Input = Enumerable.Range(-10, 40).Select(i => i * 0.1).ToArray();

		internal static double[] GetInputs()
		{
			return Input;
		}
	}
}
