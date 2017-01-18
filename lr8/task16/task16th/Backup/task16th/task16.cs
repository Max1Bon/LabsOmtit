using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task16th
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
                if (arr[i] > 4)
                {
                    Console.WriteLine("error: <=4");
                    return;
                }
                arr[i] = int.Parse(Console.ReadLine());
            }
            k = 0;
             
            //подсчет
            
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            k++;
                        }
                    }
                    arr2[i] = k;
                    k = 0;
                }  

            //вывод 2-го
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]);
            }
        }
    }
}
