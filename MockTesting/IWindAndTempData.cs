using System;
using System.Collections.Generic;
using System.Text;

namespace MockTesting
{

	public interface IWindAndTempData
	{
		void GetValues(
			double pRemainingDistance,
			double pAltitude,
			out Wind pWind,
			out double pDISA
		);

		double TropopauseAltitude { get; set; }

	}

	class WindAndTempData : IWindAndTempData
	{
		public void GetValues(double pRemainingDistance, double pAltitude, out Wind pWind, out double pDISA)
		{
			var random = new Random();
			pWind.XWind = random.Next();
			pWind.YWind = random.Next();

			pDISA = random.Next();
		}

		public double TropopauseAltitude { get; set; } = 36000.0;
	}

	public struct Wind
	{
		public double XWind;

		public double YWind;
	}
}
