using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Определить, сколько раз встречается минимальное число. 
//Количество чисел заранее не известно. Данные в файле написаны в столбик без дополнительного оформления
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            
            Console.WriteLine("введите номер файла");
            int file_number = int.Parse(Console.ReadLine());

            //проверка на наличе файла
            if (!File.Exists("test" + file_number + ".txt"))
            {
                Console.WriteLine("error");
                return;
            }

            string[] text = File.ReadAllLines("test" + Convert.ToString(file_number) + ".txt");

            //сколько раз встречается мин
            try
            {
                int min = Convert.ToInt32(text[0]);

                for (int i = 0; i < text.Length; i++)
                {
                    if (Convert.ToInt32(text[i]) < min)
                    {
                        min = Convert.ToInt32(text[i]);
                    }
                }

                for (int i = 0; i < text.Length; i++)
                {
                    if (Convert.ToInt32(text[i]) == min)
                    {
                        count++;
                    }

                }

                Console.WriteLine(count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: "+ e.Message);
            }
        }
    }
}
