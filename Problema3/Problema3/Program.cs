using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, min=int.MaxValue, max=int.MinValue;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i]<min)
                {
                    min = a[i];
                }
                if (a[i]>max)
                {
                    max = a[i];
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if (a[i]==min)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                if (a[i] == max)
                {
                    Console.Write(i + " ");
                }
            }
            Console.Read();
        }
    }
}
