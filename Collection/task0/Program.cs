using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> lst = new List<int>(); //скобки = конструктор
            double sum = 0;

            for (int i = 0; i < n; i++) //count = размер
            {
                lst.Add(Int32.Parse(Console.ReadLine()));

                sum = sum + lst[i];
            }

            Console.WriteLine(sum/lst.Count);
        }
    }
}
