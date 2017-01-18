using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double c, r;
            String s;
            s = Console.ReadLine();
            r = Double.Parse(s);
            c = 2 * Math.PI * r;
            Console.WriteLine(String.Format("{0:0.0000}",c));
        }
    }
}
