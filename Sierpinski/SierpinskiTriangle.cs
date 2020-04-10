using System;
using System.Drawing;
using System.Linq;

namespace Sierpinski
{
	public static class SierpinskiTriangle
	{
	
		public static void Draw(Point p1, Point p2, Point p3, Graphics pictureBox)
		{
			var distance12 = GetDistance(p1,p2);
			var distance13 = GetDistance(p1, p3);
			var distance23 = GetDistance(p2, p3);
			var minDistance = new[] {distance12, distance13, distance23}.Min();

			// Check end condition			
			if (minDistance > 10)
			{
				// Calculate middle points of each side			
				Point middlePoint12 = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
				Point middlePoint13 = new Point((p1.X + p3.X) / 2, (p1.Y + p3.Y) / 2);
				Point middlePoint23 = new Point((p2.X + p3.X) / 2, (p2.Y + p3.Y) / 2);

				// Recursive function calls for new triangles
				Draw(p1, middlePoint12, middlePoint13, pictureBox);
				Draw(middlePoint12, p2, middlePoint23, pictureBox);
				Draw(middlePoint13, middlePoint23, p3, pictureBox);
			}
			else
			{
				pictureBox.FillPolygon(new SolidBrush(Color.Black), new[] {p1, p2, p3,});
			}
		}

		private static double GetDistance(Point p1, Point p2)
		{
			return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
		}

	}
}


