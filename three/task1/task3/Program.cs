using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, b;           
            Console.WriteLine("введите число: ");
            k = int.Parse(Console.ReadLine());           
            if (k > 0) 
            {
                Console.WriteLine(Math.Sqrt(k));

            } else           
            {
                Console.WriteLine(k*k);
            }
        }
        }
    }
