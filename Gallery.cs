using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAproject
{
    public partial class Gallery : Form
    {
        MainMenu mm = new MainMenu();
		Warehouse wh = new Warehouse();
        public Gallery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

			int[] val = { 60, 100, 120, 300, 500, 130, 350, 700 };
			int[] wt = { 147, 249, 274, 241, 227, 184, 185, 181 };
			int W = 1000;
			int n = val.Length;

		 

			int max(int a, int b)
			{
				return (a > b) ? a : b;
			}

			// Prints the items which are put
			// in a knapsack of capacity W
			 
				int i, w;
				int[,] K = new int[n + 1, W + 1];

				// Build table K[][] in bottom up manner
				for (i = 0; i <= n; i++)
				{
					for (w = 0; w <= W; w++)
					{
						if (i == 0 || w == 0)
							K[i, w] = 0;
						else if (wt[i - 1] <= w)
							K[i, w] = Math.Max(val[i - 1] +
									K[i - 1, w - wt[i - 1]], K[i - 1, w]);
						else
							K[i, w] = K[i - 1, w];
					}
				}

				// stores the result of Knapsack
				int res = K[n, W];
				Console.WriteLine(res);

				w = W;
				for (i = n; i > 0 && res > 0; i--)
				{

					// either the result comes from the top
					// (K[i-1][w]) or from (val[i-1] + K[i-1]
					// [w-wt[i-1]]) as in Knapsack table. If
					// it comes from the latter one/ it means
					// the item is included.
					if (res == K[i - 1, w])
						continue;
					else
					{

						// This item is included.
						Console.Write(wt[i - 1] + " ");
						if (wt[i - 1] == 147)
						{
							PictureBox pb1 = new PictureBox();
							pb1.Image = Image.FromFile("C:/Users/Khan Computer/Pictures/download (1).jpg");
							pb1.Location = new Point(30, 200);
							pb1.Size = new Size(147, 200);
							this.Controls.Add(pb1);
						}
						else if (wt[i - 1] == 249)
						{
							PictureBox pb2 = new PictureBox();
							pb2.Image = Image.FromFile("C:/Users/Khan Computer/Pictures/download (2).jpg");
							pb2.Location = new Point(100, 200);
							pb2.Size = new Size(249, 200);
							this.Controls.Add(pb2);
						}
						else if (wt[i - 1] == 274)
						{
							PictureBox pb3 = new PictureBox();
							pb3.Image = Image.FromFile("C:/Users/Khan Computer/Pictures/download (3).jpg");
							pb3.Location = new Point(200, 200);
							pb3.Size = new Size(274, 200);
							this.Controls.Add(pb3);
						}
						else if (wt[i - 1] == 241)
						{
							PictureBox pb4 = new PictureBox();
							pb4.Image = Image.FromFile("C:/Users/Khan Computer/Pictures/images (4).jpg");
							pb4.Location = new Point(200, 200);
							pb4.Size = new Size(241, 200);
							this.Controls.Add(pb4);
						}
						else if (wt[i - 1] == 227)
						{
							PictureBox pb5 = new PictureBox();
							pb5.Image = Image.FromFile("C:/Users/Khan Computer/Pictures/images (1).jpg");
							pb5.Location = new Point(450, 200);
							pb5.Size = new Size(227, 200);
							this.Controls.Add(pb5);
						}
						else if (wt[i - 1] == 184)
						{
							PictureBox pb6 = new PictureBox();
							pb6.Image = Image.FromFile("C:/Users/Khan Computer/Pictures/images (2).jpg");
							pb6.Location = new Point(500, 200);
							pb6.Size = new Size(184, 200);
							this.Controls.Add(pb6);
						}
						else if (wt[i - 1] == 185)
						{
							PictureBox pb7 = new PictureBox();
							pb7.Image = Image.FromFile("C:/Users/Khan Computer/Pictures/images (3).jpg");
							pb7.Location = new Point(700, 200);
							pb7.Size = new Size(185, 200);
							this.Controls.Add(pb7);
						}
						else if (wt[i - 1] == 181)
						{
							PictureBox pb8 = new PictureBox();
							pb8.Image = Image.FromFile("C:/Users/Khan Computer/Pictures/download.jpg");
							pb8.Location = new Point(900, 200);
							pb8.Size = new Size(181, 200);
							this.Controls.Add(pb8);
						}

						// Since this weight is included its
						// value is deducted
						res = res - val[i - 1];
						w = w - wt[i - 1];
					}

				}
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
