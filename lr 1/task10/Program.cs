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
            double x, y;
            x = Double.Parse(Console.ReadLine());
            y = Double.Parse(Console.ReadLine());
            Console.WriteLine("INSERT INTO points (x, y) VALUES ('"+x+"', '"+y+"');");
        }
    }
}
