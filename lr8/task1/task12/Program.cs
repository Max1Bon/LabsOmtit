using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, n;
            Console.WriteLine("vvedie x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("vvedie y: ");
            y = int.Parse(Console.ReadLine());
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
            //Заменить все элементы, равные X, на Y.
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    arr[i] = y;
                }
            }

            Console.WriteLine("итог: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
