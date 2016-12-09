using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
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
                //выводим год
                //Console.WriteLine(str.Substring(0, 4));

                //выводим день
                string day;
                if (str.IndexOf(',', 5) == 6)
                {
                    //Console.WriteLine(str.Substring(5, 1));
                    day = str.Substring(5, 1);

                }
                else
                {
                    //Console.WriteLine(str.Substring(5, 2));
                    day = str.Substring(5, 2);
                }

                //Выводим месяц
                int begin = str.IndexOf(',', 5)+1;
                int count = str.Length - begin;
               // Console.WriteLine(str.Substring(begin, count));
                
                string month = str.Substring(begin, count);
                 
                string year = str.Substring(0, 4);

                //если 
                if (month == "1")
                {
                    month = "Января";
                }
                else if (month == "2")
                {
                    month = "Декабря";
                }
                else
                {
                    month = "месяц неверный";
                }

                Console.WriteLine("day: " + day + "month: "+ month + "year: "+ year);
                a++;

               
            }

            //закрытие файоа
            sr2.Close();
        }
    }
}
