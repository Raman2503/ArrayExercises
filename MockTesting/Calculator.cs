using System;
using System.Collections.Generic;
using System.Text;

namespace MockTesting
{
	public class Calculator
	{
		public IWindAndTempData PWindAndTempData { get; }

		public Calculator(IWindAndTempData pWindAndTempData)
		{
			PWindAndTempData = pWindAndTempData;
		}

		public double Calculate(
			double pRemainingDistance, 
			double pAltitude
		)
		{
			Wind wind;
			double DISA;
			PWindAndTempData.GetValues(pRemainingDistance, pAltitude, out wind, out DISA);

			return wind.XWind + DISA;
		}
	}
}
