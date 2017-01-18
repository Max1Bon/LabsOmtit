using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
           
            Console.WriteLine("введите 1 число: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите 2 число: ");
            b = int.Parse(Console.ReadLine());
            Calc.task1(a, b);
        }

    }
}
