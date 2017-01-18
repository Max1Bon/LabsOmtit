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
            int b, e, n;

            Console.WriteLine("размер массива: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("b<=e; b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("e: ");
            e = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("итог: ");
            for (int i = b; i <= e; i++)
            {              
                    Console.Write(arr[i]);              
            }
            Console.WriteLine();
        }
    }
}
