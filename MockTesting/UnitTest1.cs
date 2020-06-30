using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
			var mock = new Mock<IWindAndTempData>();

			// Get property 
			mock.Setup(data => data.TropopauseAltitude).Returns(trop);
				
			mock.Setup(data => data.GetValues(It.IsAny<double>(), It.IsAny<double>(),
				out wind, out temp)).Callback(new MyCallback(
				(double remDist, double alt, out Wind wind, out double DISA) =>
				{
					wind.XWind = 10.0;
					wind.YWind = 5.0;
					DISA = 20.0;
				}));

			var calc = new Calculator(mock.Object);

			var actual = calc.Calculate(200.0, 30000.0);

			// actual is 30
			Assert.AreEqual(30.0, actual);
			Console.WriteLine(mock.Object.TropopauseAltitude);
		}
	}
}
