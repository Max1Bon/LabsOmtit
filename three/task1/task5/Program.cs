using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double metr1, metr2, p, L;
            Console.WriteLine("введите 1-е знач-е:");
            L = double.Parse(Console.ReadLine());
            Console.WriteLine("введите 2-е знач-е:");
            p = double.Parse(Console.ReadLine());
            metr1 = p * 0.305;
            metr2 = L * 1000;

            Calc.task5(L, p);
            
            
        }
    }
}
