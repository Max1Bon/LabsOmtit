using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            c = double.Parse(Console.ReadLine());
            d = (b * b) - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine("a должно быть неравно 0");
                return;
            }
            if (d == 0)
            {
                Console.WriteLine("Уравнение "+a+"x^2 + "+b+"x + "+c+" = 0 имеет один корень");
            }
            else
            {
                if (d > 0)
                {
                    Console.WriteLine("Уравнение " + a + "x^2 + " + b + "x + " + c + " = 0 имеет два корня");
                }
                else
                {
                    Console.WriteLine("Уравнение " + a + "x^2 + " + b + "x + " + c + " = 0 не имеет корней");
                }
            }
        }
    }
}
