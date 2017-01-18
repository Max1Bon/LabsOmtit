using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int t = int.Parse(Console.ReadLine()); //номер вводимого файла
            //проверка на наличе файла
            if (!File.Exists("test" + t + ".txt"))
            {
                Console.WriteLine("error");
                return;
            }

            StreamReader sr2 = new StreamReader("test"+t+".txt");

            //вывод содержимого
            while (!sr2.EndOfStream)
            {
                if (a !=0)
                {
                    Console.Write("," + sr2.ReadLine());
                }
                   else Console.Write(sr2.ReadLine());
                a++;
            }

            //закрытие файоа
            sr2.Close();
        }
    }
}
