using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, n;
            Console.WriteLine("vvedie s: ");
            s = int.Parse(Console.ReadLine());
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
            //сдвигаем
            for (int i = 0; i < s; i++)
            {
                int arrLast = arr[arr.Length - 1];
                for (int j = arr.Length-1; j >0; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[0] = arrLast;
            }

            Console.WriteLine("итог: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ "\t");
            }
            Console.WriteLine();
        }
    }
}
