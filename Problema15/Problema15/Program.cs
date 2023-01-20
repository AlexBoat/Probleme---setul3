using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int [n+1];
            for(int i=1; i<=n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    if (a[i] == a[j] && i!=j)
                    {
                        if(j==n)
                        {
                            n--;
                        }
                        else
                        {
                            for (int k = j; k < n; k++)
                            {
                                a[k] = a[k + 1];
                            }
                            n--;
                        }
                    }
                }
            }
            for(int i=1; i<=n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Read();
        }
    }
}
