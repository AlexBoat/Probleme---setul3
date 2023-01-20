using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problema10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, dr, st=1, poz=-1, m, k;
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n + 1];
            dr = n;
            for (int i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (st < dr && poz == -1)
            {
                m = (st + dr) / 2;
                if (a[m] == k)
                    poz = m;
                else
                {
                    if(a[m] < k)
                        st = m + 1;
                    else
                        dr = m - 1;
                }

            }
            Console.WriteLine(poz);
            Console.Read();
        }
    }
}
