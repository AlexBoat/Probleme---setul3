using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, aux=0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= n/2; i++)
            {
                a[i] = a[i] + a[n - i + 1];
                a[n - i + 1] = a[i] - a[n - i + 1];
                a[i] = a[i] - a[n - i + 1];
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Read();
        }
    }
}
