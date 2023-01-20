using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=k; i<n-1; i++)
            {
                a[k] = a[k+1];
            }
            n--;
            for(int i=0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Read();
        }
    }
}
