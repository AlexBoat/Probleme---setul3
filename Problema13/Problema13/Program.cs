using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                int x = a[i];
                int p = i - 1;
                while (p >= 0 && a[p] > x)
                {
                    a[p + 1] = a[p];
                    p--;
                }
                a[p + 1] = x;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Read();
        }
    }
}
