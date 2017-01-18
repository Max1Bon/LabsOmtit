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
            Double c, a;
            String s;
            s = Console.ReadLine();
            a = Double.Parse(s);
            c = a * (Math.PI / 180);
            Console.WriteLine(String.Format("{0:0.0000}", c));
        }
    }
}
