using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, e, k;
            n = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            a[k] = e;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Read();
        }
    }
}
