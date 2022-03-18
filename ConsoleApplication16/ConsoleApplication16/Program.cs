using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S =  n^2 + (n + 1)^2 + (n + 2)^2 + ... + (2n)^2");
            double S = 0, n, i;
            n = Int32.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                S = S + Math.Pow(n + i,2);
            }
            Console.WriteLine("Ответ: " + S);
            Console.ReadKey();
        }
    }
}
