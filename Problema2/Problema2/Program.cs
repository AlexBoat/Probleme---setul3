using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k, pozitie=-1;
            bool ok = false;

            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i]==k && ok == false)
                {
                    pozitie = i;
                    ok = true;
                }
            }
            Console.WriteLine(pozitie);
            Console.Read();
        }
    }
}
