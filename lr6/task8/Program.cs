using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum;
            Console.Write("i: ");
            i = int.Parse(Console.ReadLine());
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());
            sum = 0;
            while (i <= n)
            {
                sum = i + sum;
                i++;
            }
            Console.Write(sum);
        }
    }
}
