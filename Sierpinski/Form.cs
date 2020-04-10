using System;
using System.Drawing;

namespace Sierpinski
{
	public partial class Form : System.Windows.Forms.Form
	{
		public Form()
		{
			InitializeComponent();
		}

			private Point _p1;
			private Point _p2;
			private Point _p3;

		private void Draw_Button_Click_1(object sender, EventArgs e)
		{
			DrawSierpinskiTriangle();
		}

		private void pictureBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawSierpinskiTriangle();
		}

		private void DrawSierpinskiTriangle()
		{
			// Define initial points of first triangle
			_p1 = new Point(pictureBox.Width / 2, 0);
			_p2 = new Point(0, pictureBox.Height);
			_p3 = new Point(pictureBox.Width, pictureBox.Height);

			var picture = pictureBox.CreateGraphics();
			picture.Clear(Color.White);

			// Function call
			SierpinskiTriangle.Draw(_p1, _p2, _p3, picture);
		}
	}
}
