using System.Drawing;

namespace Sierpinski
{
	public static class Logic
	{
		private static int counter;

		public static void DrawSerpinskiTriangle(Point p1, Point p2, Point p3, int depth)
		{
			// end condition
			counter++;
			if (counter == depth)
			{
				return;
			}

			else
			{
				// calculate middle points of each side			
				Point middlePoint12 = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
				Point middlePoint13 = new Point((p1.X + p3.X) / 2, (p1.Y + p3.Y) / 2);
				Point middlePoint23 = new Point((p2.X + p3.X) / 2, (p2.Y + p3.Y) / 2);

				// recursive call
				DrawSerpinskiTriangle(p1, middlePoint12, middlePoint13, depth);
				DrawSerpinskiTriangle(middlePoint12, p2, middlePoint23, depth);
				DrawSerpinskiTriangle(middlePoint13, middlePoint23, p3, depth);
			}
		}
	}
}
