using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("а должно быть <= b");
            Console.Write("введите а:");
            a = int.Parse(Console.ReadLine());
            Console.Write("введите b:");
            b = int.Parse(Console.ReadLine());

            if (b < a) { Console.WriteLine("ошибка"); return; }

            while (a <= b)
            {
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
