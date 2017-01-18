using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("введите число: ");
            a = int.Parse(Console.ReadLine());            
            if (a < 0) 
            {
                Console.WriteLine(a*(-1));
            } else           
            {
                Console.WriteLine(a);
            }
        }
        }
    }
