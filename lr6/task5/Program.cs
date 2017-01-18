using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            int a;
            Console.Write("введите символ: ");
            b = Console.ReadLine();
            Console.Write("число: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\"");

            while (a > 0)
            {
                Console.Write(b);
                a--;
            }
            Console.Write("\"");

        }
    }
}
