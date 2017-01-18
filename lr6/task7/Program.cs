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
            int sem, i, k;
            Console.WriteLine("таблица умножения на 7");
            sem = 7;
            i = 1;
            k = 0;

            while (i <= 10)
            {
                k = sem * i;
                Console.WriteLine(i+" x "+" 7 " + "= " + k);
                i++;
            }
        }
    }
}
