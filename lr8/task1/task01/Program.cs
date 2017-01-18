using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d;
            n = int.Parse(Console.ReadLine());
            int [] arr;
            arr = new int [n];
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i]=int.Parse(Console.ReadLine());
            }

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
