using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 1];
            a[0] = 1;
            a[1] = 1;
            for( int i = 2; i<= Math.Sqrt(n); i++)
            {
                if (a[i] == 0)
                    for (int j = 2; j <= n / i; j++)
                        a[i * j] = 1;
            }
            for(int i=1; i<=n; i++)
            {
                if (a[i] == 0)
                    Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
