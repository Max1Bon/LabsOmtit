using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("vvedite razmernost' massiva: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];

            Console.Write("vvedite massiv: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 9)
                {
                    Console.WriteLine("error: <=4");
                    return;
                }
                arr[i] = int.Parse(Console.ReadLine());
            }

            k = 0;
            int z = arr[0];
            //подсчет

            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (z != arr[i])
                    {
                        k++;
                    }
                }
               
            }

            //вывод 2-го
            Console.WriteLine("итог: "+k);
        }
    }
}
