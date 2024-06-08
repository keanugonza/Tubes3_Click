using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Algoritma_BM
    {
        public static int BM(string text, string pattern)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern))
                return -1; // no match if text or pattern is null or empty

            int[] last = BuildLast(pattern);
            int n = text.Length;
            int m = pattern.Length;
            int i = m - 1;

            if (i > n - 1)
                return -1; // no match if pattern is longer than text

            int j = m - 1;

            do
            {
                if (pattern[j] == text[i])
                {
                    if (j == 0)
                        return i; // match
                    else
                    {
                        i--;
                        j--;
                    }
                }
                else
                {
                    int lo = last[text[i]]; // last occurrence
                    i = i + m - Math.Min(j, 1 + lo);
                    j = m - 1;
                }
            } while (i <= n - 1);

            return -1; // no match
        }

        public static int[] BuildLast(string pattern)
        {
            int[] last = new int[char.MaxValue + 1]; // support for all Unicode characters
            for (int i = 0; i < last.Length; i++)
                last[i] = -1; // initialize array

            for (int i = 0; i < pattern.Length; i++)
                last[pattern[i]] = i;

            return last;
        }


        
    }
}
