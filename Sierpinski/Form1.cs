using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sierpinski
{
	public partial class Form1 : Form
	{
		private Point p1;
		private Point p2;
		private Point p3;
		int depth = 4;

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

			// Function call
			Logic.DrawSerpinskiTriangle(p1, p2, p3, depth);
			
			// Draw in UI
			var picture = pictureBox.CreateGraphics();
			picture.DrawPolygon(new Pen(Color.Black), new Point[]
				{
					p1,
					p2,
					p3,
				});
		}
	}
}
