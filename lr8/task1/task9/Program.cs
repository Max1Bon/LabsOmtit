using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, n;
            Console.WriteLine("vvedie b: ");
            b = int.Parse(Console.ReadLine());
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
            // проверяем
            int arrMin = arr[b];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arrMin)
                    k = k + 1;
            }

            Console.WriteLine("итог: "); 
            Console.Write(k);
            Console.WriteLine();
        }
    }
}
