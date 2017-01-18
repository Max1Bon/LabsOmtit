using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, gr, ft, i;
            Console.WriteLine("введите кол-во фунтов: ");
            ft = Int32.Parse(Console.ReadLine());
            gr = 453;
            k = 0;
            i = 1;
            Console.WriteLine();

            while (i <= ft)
            {
                Console.Write(i);
                k = k + gr;
                Console.Write("		"+k);
                i++;
                Console.WriteLine();
            }
        }
    }
}
