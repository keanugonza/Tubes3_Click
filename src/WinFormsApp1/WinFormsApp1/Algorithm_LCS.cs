using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Algorithm_LCS
    {
        public static int[,] LCSLength(string X, string Y)
        {
            int m = X.Length;
            int n = Y.Length;
            int[,] c = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        c[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        c[i, j] = c[i - 1, j - 1] + 1;
                    else
                        c[i, j] = Math.Max(c[i - 1, j], c[i, j - 1]);
                }
            }

            return c;
        }

        public static string PrintLCS(int[,] c, string X, string Y, int i, int j)
        {
            if (i == 0 || j == 0)
                return "";

            if (X[i - 1] == Y[j - 1])
                return PrintLCS(c, X, Y, i - 1, j - 1) + X[i - 1];

            if (c[i, j - 1] > c[i - 1, j])
                return PrintLCS(c, X, Y, i, j - 1);
            else
                return PrintLCS(c, X, Y, i - 1, j);
        }
    }
}
