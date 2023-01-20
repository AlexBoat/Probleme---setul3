using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k, aux;
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            if(k!=n)
            {
                if(k>n)
                {
                    k = n - k;
                }
                while(k!=0)
                {
                    aux = a[1];
                    for (int i = 2; i <= n; i++)
                    {
                        a[i - 1] = a[i];
                    }
                    a[n] = aux;
                    k--;
                }
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Read();
        }
    }
}
