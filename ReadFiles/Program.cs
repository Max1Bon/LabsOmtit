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
            string textShow;
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

                //удаляем запятые
                str = str.Replace(" ", "");

                //если в строке символов больше
                if (str.Length > 10)
                {
                    textShow = "неверная дата";
                }
                //выводим день
                string day;
                if (str.IndexOf(',', 5) == 6)
                {
                    day = str.Substring(5, 1);
                }
                else
                {
                    //Console.WriteLine(str.Substring(5, 2));
                    day = str.Substring(5, 2);
                }

                //Выводим месяц
                int begin = str.IndexOf(',',5)+1;
                int count = str.Length - begin;
               
                string month = str.Substring(begin, count);
                 
                string year = str.Substring(2, 2);

                if (Convert.ToInt32(day) > Convert.ToInt32("31"))
                {
                    day = "неверный день";
                }
                //если 
                if (month == "1")
                {
                    month = "Января";
                }
                else if (month == "2")
                {
                    month = "Февраля";
                }
                else if (month == "3")
                {
                    month = "Марта";
                }
                else if (month == "4")
                {
                    month = "Апреля";
                }
                else if (month == "5")
                {
                    month = "Мая";
                }
                else if (month == "6")
                {
                    month = "Июня";
                }
                else if (month == "7")
                {
                    month = "Июля";
                }
                else if (month == "8")
                {
                    month = "Августа";
                }
                else if (month == "9")
                {
                    month = "Сентября";
                }
                else if (month == "10")
                {
                    month = "Октября";
                }
                else if (month == "11")
                {
                    month = "Ноября";

                    if (day == "31")
                    {
                        Console.WriteLine("невозможная дата");
                    }
                }
                else if (month == "12")
                {
                    month = "Декабря";
                }
                else
                {
                    month = "месяц неверный";
                    
                }

                //Console.WriteLine(textShow);
                Console.WriteLine(day +" "+ month + " "+ year + " г.");
                a++;

               
            }

            //закрытие файла
            sr2.Close();
        }
    }
}
