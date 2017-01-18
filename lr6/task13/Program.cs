using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти сумму кубов всех целых чисел от 20 до 40 включительно.");
            
            double a, sum;
            sum = 0;
            a = 20; 
            while (a <= 40)
            {
                sum = Math.Pow(a, 3) + sum;
                a++;
            }
            Console.WriteLine(sum);
        }
    }
}
