using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, v;
            Console.Write("r= ");
            r = double.Parse(Console.ReadLine());
            v = 4 * Math.PI * Math.Pow(r, 3) / 3;
            Console.WriteLine("Обьем шара: {0:0.0000}",v);
        }
    }
}
