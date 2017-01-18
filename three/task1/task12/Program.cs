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
            int x, y, z;
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("z: ");
            z = int.Parse(Console.ReadLine());

            if (x==y || x==z || y==z)
            {
                Console.WriteLine("Среди чисел есть равные");
            } else
                Console.WriteLine("Числа не равны друг другу.");
        }
    }
}
