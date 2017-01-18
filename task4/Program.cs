using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    //Определить, сколько раз встречаются числа, которые делятся без остатка на А. 
    //Количество чисел в файле заранее неизвестно.
    class Program
    {

        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Введите номаер файла:");
            int file_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите A:");
            int a = int.Parse(Console.ReadLine());
            string[] text = File.ReadAllLines("test"+file_number+".txt");

            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (Convert.ToInt32(text[i]) % a == 0)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
