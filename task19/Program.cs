using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Пользователь вводит символ А и символ B. Это буквы латинского алфавита. Посчитать количество символов, 
//которые находятся в файле между А и B. Всего в файле находится заранее неизвестное количество символов. 
//Они записаны в одну строчку.
namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввелите номер файла");
            int t = int.Parse(Console.ReadLine());

            Console.WriteLine("введите символ 1");
            char symbol = Char.Parse(Console.ReadLine());

            Console.WriteLine("введите символ 2");
            char symbol2 = Char.Parse(Console.ReadLine());

            //проверка на наличе файла
            if (!File.Exists("test" + t + ".txt"))
            {
                Console.WriteLine("error");
                return;
            }


            if (symbol == symbol2)
            {
                Console.WriteLine("error");
                return;
            }


            //Класс StreamReader позволяет нам легко считывать весь текст или отдельные строки из текстового файла. 
            //класс имеет такие методы как 
            //ReadLine: считывает одну строку в файле
            StreamReader sr2 = new StreamReader("test" + t + ".txt");

            int countSymbol = 0;
            int countChars = 0;



            //считываем файл
            while (!sr2.EndOfStream) //пока не закончился файл
            {
                String str = sr2.ReadLine(); //строка в str
                Console.WriteLine(str); //вывод str
                int symbolPos = str.IndexOf(symbol);
                int symbolPos2 = str.IndexOf(symbol2);
                var chars = str.ToCharArray();



                if (symbolPos2 < symbolPos)
                {
                    Console.WriteLine("error");
                    return;
                }
                if (!str.Contains(symbol2) || !str.Contains(symbol))
                {
                    Console.WriteLine("error");
                    return;
                }

                Console.WriteLine(symbolPos2 - symbolPos -1);

           
            }
        }
    }
}
