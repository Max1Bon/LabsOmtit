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
            double cx, cy, r;
            string fill;
            cx = Double.Parse(Console.ReadLine());
            cy = Double.Parse(Console.ReadLine());
            r = Double.Parse(Console.ReadLine());
            fill = Console.ReadLine();
            Console.WriteLine("< circle cx = \""+cx+"\" cy = \""+cy+"\" r = \""+r+"\" fill = \""+fill+"\" /> ");
        }
    }
}
