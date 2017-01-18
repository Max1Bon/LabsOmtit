using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, y;
            Console.WriteLine("vvedie k: ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("vvedie razmernost' massiva n: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            y = 0;

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

            //подсчет
            for (int i = 0; i < arr.Length; i++)
            {
                if (k == arr[i])
                    y++;
                
            }

            Console.WriteLine(y);
        }
    }
}
