using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, aux;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            aux = a[1];
            for (int i = 2; i <= n; i++)
            {
                a[i - 1] = a[i];
            }
            a[n] = aux;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Read();
        }
    }
}
