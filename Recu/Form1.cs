using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var graphics = pictureBox1.CreateGraphics();
			graphics.DrawRectangle(new Pen(Color.Red), 10, 10, 100, 100);
			graphics.FillPolygon(new LinearGradientBrush(new Point(0, 0), new Point(20, 50), Color.Green, Color.Yellow), new Point[]
			{
				new Point(0,0),
				new Point(30, 0),
				new Point(20, 50), 
			});


			graphics.DrawRectangle(new Pen(Color.Black), pictureBox1.DisplayRectangle);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			List<int> fibs = new List<int>();
			for (int i = 0; i < 10; i++)
			{
				fibs.Add(Fibonachi(i));
			}

			var values = String.Join(", ", fibs);
			MessageBox.Show(values);
		}

		public int Fibonachi(int n)
		{
			//end condtion
			if (n == 0)
				return 0;
			if (n == 1)
				return 1;
			

			//recursive calls go here
			return Fibonachi(n - 1) + Fibonachi(n - 2);
		}


		public void DrawSerpinskiTriangle(Point a1, Point a2, Point a3, int depth)
		{
			// end condition
			// end algorithm when depth reached

			// Draw triangle
			// calculate middle points
			// take those middle points and draw three internal triangles with recursive calls
			// DrawSerpinskiTriangle(mp1, mp2, a3, depth+1)
			// DrawSerpinskiTriangle(mp1, m2, m3, depth+1)
			// DrawSerpinskiTriangle(mp1, m2, m3, depth+1)
		}
	}
}
