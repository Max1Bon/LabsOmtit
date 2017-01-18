using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double a, b, sum;
            Console.WriteLine("Найти сумму квадратов всех целых чисел от A до B включительно (значение А и B вводится B>=A).");
            Console.Write("a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine());
            sum = 0;

            if (a > b)
            {
                Console.WriteLine("ошибка. а должно быть <= b");
                return;
            }
            while (a <= b)
            {
                sum = Math.Pow(a, 2) + sum;
                a++;
            }
            Console.WriteLine(sum);
        }
    }
}
