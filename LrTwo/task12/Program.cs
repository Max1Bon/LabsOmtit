using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            y = 3 * (Math.Sqrt(x));
            Console.WriteLine("результат: {0:0.0000}",y);

        }
    }
}
