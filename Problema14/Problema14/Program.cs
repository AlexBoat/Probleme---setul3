using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, p;
            n = Convert.ToInt32(Console.Read());
            int[] a = new int[n + 1];
            p = n;
            for(int i=1; i<=n; i++)
            {
                a[i] = Convert.ToInt32(Console.Read());
            }
            for (int i = 1; i <= n; i++)
            {
                if (a[i]==0)
                {
                     a[i] = a[p];
                     a[p] = 0;
                     p--;
                }
            }
            for(int i=1; i<=n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Read();
        }
    }
}
