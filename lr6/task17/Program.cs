using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, k;
            a = 100;
            k = 0;
            while (a <= 1000)
            {
                if (a % 13 == 0)
                {
                    k++;
                }
                a++;
            }
            Console.WriteLine(k);
        }
    }
}
