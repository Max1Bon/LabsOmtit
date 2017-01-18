using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum;
            Console.WriteLine("значение А вводится -100<=A<=500");
            Console.Write("считаем сумму от A до 500, введите А: ");
            a = int.Parse(Console.ReadLine());
            sum = 0;

            if (a < -100)
            {
                Console.WriteLine("ошибка, значение А вводится -100<=A<=500");
                return;
            }

            while (a <= 500)
            {
                sum = a + sum;
                a++;
            }
            Console.Write(sum);
            Console.WriteLine();
        }
    }
}
