using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LrTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Double c,x;
            String s;
            s = Console.ReadLine();
            x = Double.Parse(s);
            c = task1(x);
            Console.WriteLine(c);
        }

        public static double task1(double x)
        {
            return 2 * x;
        }
    }
}
