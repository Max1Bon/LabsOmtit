using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int t = int.Parse(Console.ReadLine());
            //проверка на наличе файла
            if (!File.Exists("test" + t + ".txt"))
            {
                Console.WriteLine("error");
                return;
            }

            StreamReader sr2 = new StreamReader("test" + t + ".txt");
            
            //вывод содержимого
            while (!sr2.EndOfStream) //пока не закончился файл
            {
                String str = sr2.ReadLine();
                string result = str.Substring(0, str.IndexOf('@'));
                Console.WriteLine(result);
                                               
            }

            //закрытие файла
            sr2.Close();
        }
    }
}
