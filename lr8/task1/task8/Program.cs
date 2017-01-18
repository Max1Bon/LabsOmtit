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
            int b, e, n;

            
            Console.Write("b<=e; b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("размер массива: ");
            n = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[n];
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[b])
                {
                    k++;
                }
            }

            Console.WriteLine(k);
            
        }
    }
}
