using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n+1];
            int suma = 0;
            for(int i=1; i<=n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                suma += a[i];
            }
            Console.WriteLine(suma);
            Console.Read();
        }
    }
}
