using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvS, krS, r, a;
            Console.Write("радиус: ");
            r = double.Parse(Console.ReadLine());
            Console.Write("сторона квадрата: ");
            a = double.Parse(Console.ReadLine());
            kvS = a * a;
            krS = Math.PI * (r * r);
            if (a < 0 || r < 0)
            {
                Console.WriteLine("радиус или сторона, должны быть > 0 ");
            }
            if (kvS > krS)
            {
                Console.WriteLine("Площадь квадрата больше площади круга");
            }
            else Console.WriteLine("Площадь круга больше площади квадрата");
        }
    }
}
