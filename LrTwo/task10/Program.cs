using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.Write("введите х: ");
            x = double.Parse(Console.ReadLine());
            x = Math.Sqrt(x);
            Console.WriteLine("корень из х = {0:0.0000}",x);
        }
    }
}
