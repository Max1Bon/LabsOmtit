using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x, y;
            Console.Write("y = ");
            y = Double.Parse(Console.ReadLine());
            x = 5 * (Math.Cos(y * Math.PI / 180));
            Console.WriteLine(String.Format("Результата: {0:0.0000}", x));
        }
    }
}
