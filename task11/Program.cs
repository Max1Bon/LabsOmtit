using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввелите номер файла");
            int t = int.Parse(Console.ReadLine());

            Console.WriteLine("введите символ");
            char symbol = Char.Parse(Console.ReadLine());

            //проверка на наличе файла
            if (!File.Exists("test" + t + ".txt"))
            {
                Console.WriteLine("error");
                return;
            }
        }
    }
}
