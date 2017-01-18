using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int w, i;
            Console.Write("ширина: ");
            w = int.Parse(Console.ReadLine());
            s = "-";
            i = 0;
            if (w < 0)
            {
                Console.WriteLine("ширина должна быть > 0");
                return;
            }

            Console.Write("+");
            while (i <= w-3)
            {
                Console.Write("-");
                i++;
            }
            Console.Write("+");
            Console.WriteLine();
            Console.Write("|");

            i = 0;
            while (i <= w - 3)
            {
                Console.Write("-");
                i++;
            }
            Console.Write("|");
            Console.WriteLine();

            i = 0;
            Console.Write("+");
            while (i <= w-3)
            {
                Console.Write("-");
                i++;
            }
            Console.Write("+");
            Console.WriteLine();
        }
    }
}
