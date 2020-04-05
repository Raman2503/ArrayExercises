using System.Drawing;

namespace Sierpinski
{
	public static class Logic
	{
	
		public static void DrawSierpinskiTriangle(Point p1, Point p2, Point p3, int depth, Graphics pictureBox)
		{
			// end condition			
			if (depth > 0)
			{
				depth--;

				// calculate middle points of each side			
				Point middlePoint12 = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
				Point middlePoint13 = new Point((p1.X + p3.X) / 2, (p1.Y + p3.Y) / 2);
				Point middlePoint23 = new Point((p2.X + p3.X) / 2, (p2.Y + p3.Y) / 2);

				// recursive call for first time
				DrawSierpinskiTriangle(p1, middlePoint12, middlePoint13, depth, pictureBox);
				DrawSierpinskiTriangle(middlePoint12, p2, middlePoint23, depth, pictureBox);
				DrawSierpinskiTriangle(middlePoint13, middlePoint23, p3, depth, pictureBox);
			}

			else
			{
				pictureBox.DrawPolygon(new Pen(Color.Black), new[]
				{
					p1,
					p2,
					p3,
				});
			}
		
		}
		
	}
}


