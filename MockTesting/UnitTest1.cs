using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace MockTesting
{
	[TestClass]
	public class UnitTest1
	{
		delegate void MyCallback(double remDist, double alt, out Wind wind, out double DISA);
		[TestMethod]
		public void TestMethod1()
		{
			// 10, 20
			var wind = new Wind();
			var temp = 0.0;
			var trop = 36000.0;
			var alt1 = 300;
			var alt2 = 350;
			var mock = new Mock<IWindAndTempData>();

			// Get property 
			mock.Setup(data => data.TropopauseAltitude).Returns(trop);

			// Mock a function with out parameter.Alt and rem distance are any values.
			//mock.Setup(data => data.GetValues(It.IsAny<double>(), It.IsAny<double>(),
			//	out wind, out temp)).Callback(new MyCallback(
			//	(double remDist, double alt, out Wind wind, out double DISA) =>
			//	{
			//		wind.XWind = 10.0;
			//		wind.YWind = 3.0;
			//		DISA = 20.0;
			//	}));


			// Alt is 300
			var mockAlt300 = mock.Setup(data => data.GetValues(It.IsAny<double>(), alt1,
				out wind, out temp)).Callback(new MyCallback(
				(double remDist, double alt, out Wind wind, out double DISA) =>
				{
					wind.XWind = 5.0;
					wind.YWind = 5.0;
					DISA = 7.0;
				}));

			// Alt is 350
			var mockAlt350 = mock.Setup(data => data.GetValues(It.IsAny<double>(), alt2,
				out wind, out temp)).Callback(new MyCallback(
				(double remDist, double alt, out Wind wind, out double DISA) =>
				{
					wind.XWind = 9.0;
					wind.YWind = 9.0;
					DISA = 9.0;
				}));

			var calc = new Calculator(mock.Object);

			var actual1 = calc.Calculate(200.0, alt1);
			var actual2 = calc.Calculate(200.0, alt2);

			// actual is 17
			Assert.AreEqual(12, actual1);
			Assert.AreEqual(18, actual2);
			Console.WriteLine(mock.Object.TropopauseAltitude);
		}
	}
}
