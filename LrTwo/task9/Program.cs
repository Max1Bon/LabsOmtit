using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Double c, x;
            String s;
            s = Console.ReadLine();
            x = Double.Parse(s);
            c = Math.Sin(x*Math.PI/180);
            Console.WriteLine(String.Format("{0:0.0000}", c));
        }
    }
}
