using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Simple_Fun_166_Best_Match
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int BestMatch(int[] goals1, int[] goals2)
        {
            int[] count = new int[goals1.Length];
            int j = 0, b = 0;

            for (int i = 0; i < goals1.Length; i++)
            {
                count[i] = goals1[i] - goals2[i];
            }
            int min = count.Min();

            for (j = count.Length - 1; j > 0; j--)
            {
                if (count[j] == min)
                { b = j; }
            }

            for (j = 0; j < count.Length; j++)
            {
                if (count[j] == min)
                {
                    if (goals1[j] * goals2[j] > goals1[b] * goals2[b]) { b = j; }

                }

            }
            return b;


        }

    }
}
