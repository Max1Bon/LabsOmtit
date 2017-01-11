using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task9
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
                var chars = str.ToCharArray();


                if (!str.Contains(symbol))
                {
                    Console.WriteLine("error");
                    return;
                }

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == symbol)
                    {
                        countSymbol++;
                    }
                    if (countSymbol > 1)
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    
                }

                for (int j = symbolPos+1; j < str.Length; j++)
                {
                    countChars++;
                }
                Console.WriteLine(countChars);

            }
        }
    }
}
