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
            int b, des, sum;
            Console.WriteLine("значение B вводится от -10 < B");
            Console.Write("введите B: ");
            b = int.Parse(Console.ReadLine());
            sum = 0;
            des = -10;

            if (b < -10)
            {
                Console.WriteLine("ошибка, значение B вводится -10 < B");
                return;
            }

            while (des <= b)
            {
                sum = des + sum;
                des++;
            }
            Console.Write(sum);
            Console.WriteLine();
        }
    }
}
