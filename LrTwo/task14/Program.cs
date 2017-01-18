using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("введите а: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("введите b: ");
            b = double.Parse(Console.ReadLine());
            c = a * (Math.Sqrt(-7 * b));
            Console.WriteLine("результата: {0:0.0000}", c);
        }
    }
}
