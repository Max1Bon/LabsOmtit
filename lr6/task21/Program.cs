using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, str;
            int k;
            Console.Write("введите символ: ");
            s = Console.ReadLine();
            Console.Write("колво строк: ");
            k = int.Parse(Console.ReadLine());
            str = s;
             if (k < 0)
            {
                Console.WriteLine("ошибка");
                return;
            }
            while (k >= 0)
            {
                Console.Write(str + "\n");
                str = str + s;
                k--;
            }
        }
    }
}
