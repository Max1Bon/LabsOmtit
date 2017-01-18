using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, w, h;
            w = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            a = 0;
            //i - строка, j- столец

            if (w < 0 || h < 0)
            {
                Console.WriteLine("ошибка");
                return;
            }

            Console.Write(" ");
            //первая строка
            for (int i = 0; i<=w-1; i++)
            {
                Console.Write(i);
                
            }
            //перв. столбец
            for (int j = 0; j <= h-1; j++)
            {
                Console.Write("\n"+j);
                while (a <= w)
                {
                    Console.Write(" ");
                    a++;
                }
                a = 0;
                Console.Write("|");

            }
            Console.WriteLine();
            Console.Write(" ");
            //последняя строка
            for (int i = 0; i <= w - 1; i++)
            {
                Console.Write("-");

            }
            Console.WriteLine();
        }
    }
}
