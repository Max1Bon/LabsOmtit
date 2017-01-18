using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q;
            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());
            if (p > q)
            {
                Console.WriteLine("Максимальное: " + p + ", минимальное: " + q);
            }
            else Console.WriteLine("Максимальное: " + q + ", минимальное: " + p); 
        }
    }
}
