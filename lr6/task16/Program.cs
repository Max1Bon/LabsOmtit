using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sum = 0;
            if (a >= b)
            {
                Console.WriteLine("значение А и В вводится В>=A");
                return;
            }
            while (a < b)
            {
                if (a % 7 == 0 )
                {
                    sum = a + sum;
                }
                a++;
            }
            Console.WriteLine(sum);
        }
    }
}
