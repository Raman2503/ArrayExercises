using System;
using System.Drawing;
using System.Windows.Forms;
// ReSharper disable All

namespace Sierpinski
{
	public partial class Form1 : Form
	{
		private Point p1;
		private Point p2;
		private Point p3;
		int depth = 9;

		public Form1()
		{
			InitializeComponent();
		}

		private void Draw_Button_Click_1(object sender, EventArgs e)
		{
			// Define initial points of first triangle
			p1 = new Point(300, 0);
			p2 = new Point(50, 300);
			p3 = new Point(550, 300);

			var picture = pictureBox.CreateGraphics();

			// Function call
			Logic.DrawSierpinskiTriangle(p1, p2, p3, depth, picture);

		}
	}
}
