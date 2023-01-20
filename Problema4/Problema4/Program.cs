using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, min = int.MaxValue, max = int.MinValue, minnr = 0, maxnr = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i]==max)
                {
                    maxnr++;
                }
                if (a[i]>max)
                {
                    max = a[i];
                    maxnr = 1;
                }
                if (a[i] == min)
                {
                    minnr++;
                }
                if (a[i] < min)
                {
                    min = a[i];
                    minnr = 1;
                }
            }
            Console.WriteLine(min + " " + minnr + " ori");
            Console.WriteLine(max + " " + maxnr + " ori");
            Console.Read();
        }
    }
}
