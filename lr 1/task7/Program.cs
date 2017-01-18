using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            Double a;
            s = Console.ReadLine();
            a=Double.Parse(s);
            Console.WriteLine(String.Format("{0:0.0000}",a));
        }
    }
}
