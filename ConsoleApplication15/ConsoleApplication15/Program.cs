using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано целое число n больше 0. Найти сумму 1 + 1/2 + 1/3 + ... + 1/n");
            double S = 0;
            double i, n;
            n = Int32.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                S = S + (1 / i);
            }
            Console.WriteLine("Ответ: " + S);
            Console.ReadKey();
        }
    }
}
