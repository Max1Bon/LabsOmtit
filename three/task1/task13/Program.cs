using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.Write("x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("z: ");
            z = double.Parse(Console.ReadLine());

            if (x >= -3 && x <= 5)
            {
                Console.WriteLine(x);
            } 
            if (y >= -3 && y <= 5)
            {
                Console.WriteLine(y);
            } 
            if (z >= -3 && z <= 5)
            {
                Console.WriteLine(z);
            }

        }
    }
}
