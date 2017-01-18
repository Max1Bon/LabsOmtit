using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task5
{
    class Program
    {
        //Определить, сколько раз встречаются такие числа, в которых есть две одинаковых цифры подряд. 
        //Например: 1123, 1223, 1233. Общее количество чисел заранее неизвестно. 
        //Все числа находятся в диапазоне от 1000 до 9999. Данные в файле написаны в столбик без дополнительного оформления.

        static void Main(string[] args)
        {
            Console.WriteLine("введите номер файла:");
            int file_number = int.Parse(Console.ReadLine());
            string[] text = File.ReadAllLines("test" + file_number + ".txt");
            int count = 0;

            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int t = Convert.ToInt32(text[i]) / 1000;
                    int h = Convert.ToInt32(text[i]) / 100 % 10;
                    int d = Convert.ToInt32(text[i]) / 10 % 10;
                    int u = Convert.ToInt32(text[i]) % 10;
                    //Console.WriteLine(u);

                    if (t == h || h == d || d == u)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " +e.Message);
            } 

        }
    }
}
