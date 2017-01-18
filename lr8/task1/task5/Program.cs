using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("vvedie m: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("vvedie razmernost' massiva n: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("vvedite massiv: ");
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 1 || arr[i] >4)
                {
                    Console.WriteLine("error:need from 1 to 4");
                    return;
                }
            }

            //умножение
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * m;
            }

            Console.WriteLine("itog: ");
            for (int i = arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i] +" ");
            }
        }
    }
}
