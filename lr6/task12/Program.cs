using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            {
               int a, b; 
                    int sum;
                Console.Write("a: ");
                a = (int)double.Parse(Console.ReadLine());
                Console.Write("b: ");
                b = (int)double.Parse(Console.ReadLine());
                a = a + 1;
                sum = 1;
                while (a <= b)
                {
                    sum = a * sum;
                    a++;
                }
                Console.Write(sum);
            }
        }
    }
}
