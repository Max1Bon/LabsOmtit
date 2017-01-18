using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double sred;

            n = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[n];
            sred=0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sred = sred + arr[i];
            }

            sred = sred / arr.Length;
            Console.WriteLine(sred);

            
        }
    }
}
