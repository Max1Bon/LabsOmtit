using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите номер файла");
            int file_number = int.Parse(Console.ReadLine());

            //проверка на наличе файла
            if (!File.Exists("test" + file_number + ".txt"))
            {
                Console.WriteLine("error");
                return;
            }

            StreamReader sr1 = new StreamReader("test" + file_number + ".txt");
            
            string[] text = File.ReadAllLines("test" + Convert.ToString(file_number) + ".txt");
            double sum = 0;

            //считаем среднее арифмитическое
            
            for (int i = 1; i < text.Length; i++)
            {
                if (Convert.ToDouble(text[i])<=20)
                {
                    sum = sum + Convert.ToDouble(text[i]);
                }
            }

            //вывод значения sum
            sum = sum / text.Length - 1;
            Console.WriteLine(sum);

            //Вывод файла
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
            //вывод содержимого
            /*while (!sr1.EndOfStream) //пока объект sr1 не закончится
            { 
              int[] text_array = sr1.ReadLine();
            }
            */
            //Найти среднее арифметическое чисел, значение которых не превышает 20. (Если число в файле > 20, то не использовать его)
            //Первое число в файле – количество чисел. Оно не участвует в вычислениях. (То есть будет массив? Числа по линиям как бы разбиты)
            //Данные в файле написаны в столбик без дополнительного оформления.
        }
    }
}
