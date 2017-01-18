using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выяснить, можно ли прямоугольник со сторонами a, b уместить внутри прямоугольника со сторонами c, d");
            int a, b, c, d;
            Console.Write("Прямоугольник 1 \nсторона а = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("сторона b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Прямоугольник 2 \nсторона c = ");
            c = int.Parse(Console.ReadLine());
            Console.Write("сторона d = ");
            d = int.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0 || d <= 0)
            {
                Console.WriteLine("error: сторона должна быть > 0");
                return;
            }

            if ((a * b) < (b * c))
            {
                Console.WriteLine("Размещение возможно");
            }
            else Console.WriteLine("Размещение невозможно");

        }
    }
}
