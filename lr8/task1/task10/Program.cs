using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, min;
            Console.WriteLine("размер массива: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("введите массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            min = arr[0];

            //поиск минимального
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            // вычет минимального из всех чисел
            for (int i = 0; i < arr.Length; i++)
            {
                    arr[i] = arr[i]-min;
            }

            Console.WriteLine("итог");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

        }
    }
}
