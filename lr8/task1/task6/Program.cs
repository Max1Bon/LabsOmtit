using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q, n;

            
            Console.WriteLine("размер массива: ");
            n = int.Parse(Console.ReadLine());
            int[] arr;
            
            arr = new int[n];
            
            Console.WriteLine("введите массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int t = arr[arr.Length-1];
            for (int i = arr.Length-1; i >= 1; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = t;
            Console.WriteLine("итог: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
