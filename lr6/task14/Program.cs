using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum, i, n;
            Console.WriteLine("сумма ряда 1/2, 1/3,..., 1/n");
            Console.Write("n: ");
            n = double.Parse(Console.ReadLine());
            sum = 0;
            i = 1;
            
            if (n <= 0)
            {
                Console.WriteLine("ошибка. n должно быть > 0");
                return;
            }

            while (i <= n)
            {
                sum = sum + (1/i);
                i++;
            }
            Console.WriteLine("{0:0.0000}",sum);
        }
    }
}
