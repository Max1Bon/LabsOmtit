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
            int b, a;
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());

            while (b >= a)
            {
                Console.Write(b+" ");
                b--;
            }
        }
    }
}
