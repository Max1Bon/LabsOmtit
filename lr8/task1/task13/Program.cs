using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("vvedie razmernost' massiva n: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("vvedite massiv: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 1 || arr[i] > 4)
                {
                    Console.WriteLine("error:need from 1 to 4");
                    return;
                }
            }
           // Инвертировать массив - переставить элементы массива в обратном порядке. 1 2 3 4 1 2 ** 2 1 4 3 2 1
            int k = 0;
            int m = 0;
            for (int i = arr.Length-1; i >= arr.Length/2; i--)
            {
                k = arr[i];
                arr[i] = arr[m];
                arr[m] = k;
                m++;
            }

            Console.WriteLine("итог: "); 
            for (int i = 0; i <arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
        }
    }
}
