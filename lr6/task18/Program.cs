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
            string s;
            int w, h, k;
            Console.Write("введите символ: ");
            s = Console.ReadLine();
            Console.Write("ширина: ");
            w = int.Parse(Console.ReadLine());
            Console.Write("высота: ");
            h = int.Parse(Console.ReadLine());
            k = w;

            if (h < 0 || w < 0)
            {
                Console.WriteLine("ширина или высота должны быть > 0");
                return;
            }
            while (h > 0)
            { 
                while (w > 0)
                {
                    Console.Write(s);
                    w--;
                }

                Console.WriteLine();
                h--;
                w = k;
            }


        }
    }
}
