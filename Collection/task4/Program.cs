using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite p:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("vvedite q:");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("vvedite n:");
            int n = int.Parse(Console.ReadLine());
            List<int> lst = new List<int>(); //скобки = конструктор

            //ввод массива
            for (int i = 0; i < n; i++) //count = размер
            {
                lst.Add(Int32.Parse(Console.ReadLine()));

             }

            //перестановка
            int z = 0;
            
                z = lst[p];
                lst[p] = lst[q];
                lst[q] = z;
            

            //вывод массива
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(lst[i]);
            }


        }
    }
}
