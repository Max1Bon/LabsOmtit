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
            int p, q, n;

           
            Console.Write("индекс p: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("индекс q: ");
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("размер массива: ");
            n = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[n];
            int t = 0;
            Console.WriteLine("введите массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            t = arr[p];
            arr[p] = arr[q];
            arr[q] = t;

            Console.WriteLine("итог: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
