using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sot, ed;
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            if (a < 1000  || a > 9999)
            {
                Console.WriteLine("a должно быть в диапазоне от 1000 до 9999");
                return;
            }
            sot = (a / 100) % 10;
            ed = a % 10;
            if (sot == ed)
            {
                Console.WriteLine("равно");
            }
            else { Console.WriteLine("не равно"); }
        }
    }
}
