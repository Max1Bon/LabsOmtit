using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, n, q;
            Console.WriteLine("vvedie p: ");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("vvedie q: ");
            q = int.Parse(Console.ReadLine());
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
            //проверка
            int arrMin = arr[p];
            for (int i = p; i <= q; i++)
            {
                if (arr[i] < arrMin)
                {
                    arrMin = arr[i];
                }
            }
            Console.WriteLine("итог: "+arrMin);
        }
    }
}
