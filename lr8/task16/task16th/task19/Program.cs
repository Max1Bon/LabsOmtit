using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("vvedite razmernost' massiva: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(100, 999);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+", ");
            }
        }
    }
}
