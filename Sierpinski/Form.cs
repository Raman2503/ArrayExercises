using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sierpinski
{
	public partial class Form : System.Windows.Forms.Form
	{
		public Form()
		{
			InitializeComponent();
			depthTextbox.Text = depth.ToString();
			depthTextbox.ReadOnly = true;
			depthTextBoxLabel.ReadOnly = true;
		}

			private Point p1;
			private Point p2;
			private Point p3;
		readonly int depth = 10;

		private void Draw_Button_Click_1(object sender, EventArgs e)
		{
			depthTextbox.Text = depth.ToString();

			// Define initial points of first triangle
			p1 = new Point(300, 0);
			p2 = new Point(50, 300);
			p3 = new Point(550, 300);

			var picture = pictureBox.CreateGraphics();

			// Function call
			SierpinskiTriangle.Draw(p1, p2, p3, depth, picture);
		}
	}
}
