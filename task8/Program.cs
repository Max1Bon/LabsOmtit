using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите номер файла");
            int t = int.Parse(Console.ReadLine());

            //проверка на наличе файла
            if (!File.Exists("test" + t + ".txt"))
            {
                Console.WriteLine("error");
                return;
            }

            StreamReader sr2 = new StreamReader("test" + t + ".txt");

            //string 
            //String showText;
            //вывод содержимого
            while (!sr2.EndOfStream) //пока не закончился файл
            {
                String str = sr2.ReadLine();

                CultureInfo russia = new CultureInfo("ru-Ru");
                DateTime d;

                if (DateTime.TryParseExact(str, new[] {"yyyy,d,M","yy,d,M"},CultureInfo.InvariantCulture,
                    DateTimeStyles.RoundtripKind | DateTimeStyles.AllowWhiteSpaces, out d))
                {
                    Console.WriteLine("{0}",d.ToString("d MMMM yy г", russia));
                }
                else
                {
                    Console.WriteLine("неверный формат входной строки");
                }

               /* //удаляем запятые
                str = str.Replace(" ", "");

                //day
                string day;
                if (str.IndexOf(',', 5) == 6)
                {
                    day = str.Substring(5, 1);
                }
                else
                {
                    day = str.Substring(5, 2);
                }

                //moth
                int begin = str.IndexOf(',', 5) + 1;
                int count = str.Length - begin;
                string month = str.Substring(begin, count);
                if (Convert.ToInt32(month) > 12)
                {
                    showText = "неверная дата";
                }
                else
                {
                    showText = day + month;
                } 

                //year
                string year = str.Substring(2, 2);
                */
                
            }
        }
    }
}
