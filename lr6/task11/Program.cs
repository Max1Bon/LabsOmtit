using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.WriteLine("ищем сумму от А до В, где В>=A");
            Console.Write("А: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            b = int.Parse(Console.ReadLine());
            sum = 0;

            if (b <a)
            {
                Console.WriteLine("ошибка, В должно быть >= A");
                return;
            }

            while (a <= b)
            {
                sum = a + sum;
                a++;
            }
            Console.Write(sum);
            Console.WriteLine();
        }
    }
}
