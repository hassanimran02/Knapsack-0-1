using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAproject
{
	static class Program
	{
		// A utility function that returns
		// maximum of two integers
		static int max(int a, int b)
		{
			return (a > b) ? a : b;
		}

		// Prints the items which are put
		// in a knapsack of capacity W
		static void printknapSack(int W, int[] wt,
								int[] val, int n)
		{
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

					// Since this weight is included its
					// value is deducted
					res = res - val[i - 1];
					w = w - wt[i - 1];
				}
			}


		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainMenu());

			int[] val = { 60,100,120,300,500,130,350,700};
			int[] wt = { 147,249,274,241,227,184,185,181};
			int W = 1000;
			int n = val.Length;

			printknapSack(W, wt, val, n);
			/* A Naive recursive implementation of
0-1 Knapsack problem */

		}
	}
}
