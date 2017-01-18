using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task6
{
    class Rectangle 
    {
            int x;
            int y;
            int width;
            int height;

        //конструктор
        public Rectangle (string x1, string y1, string w1, string h1) 
        {
            x = Convert.ToInt32(x1);
            y = int.Parse(y1);
            width = int.Parse(w1);
            height = int.Parse(h1);

        }

        public int Square()
        {
            return width * height;
        }

    }

    class Program
    {
        // Компаратор создаётся для сортировки
        static int CompareBySquare(Rectangle left, Rectangle right)
        {
            if (left.Square() > right.Square())
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("введите номер файла");
            int file_number = int.Parse(Console.ReadLine());


            //проверка на наличе файла
            if (!File.Exists("test" + file_number + ".csv"))
            {
                Console.WriteLine("error");
                return;
            }

            StreamReader sr2 = new StreamReader("test" + file_number + ".csv");
            List<Rectangle> rectangleList = new List<Rectangle>();

            
            
            while (!sr2.EndOfStream) //пока не закончился файл
            {
                String str = sr2.ReadLine();
                string[] temp = str.Split(';');

                Rectangle rect = new Rectangle(temp[0], temp[1], temp[2], temp[3]);
                rectangleList.Add(rect);
            }

            //Сортировка
            rectangleList.Sort(CompareBySquare);
            //Вывод отсортированного
            for (int i = 0; i < rectangleList.Count; i++)
            {
                Rectangle item = rectangleList[i]; //
                Console.WriteLine(item.Square());
            }
           /*//поиск максимальной площади
            int max = rectangleList[0].Square();
            foreach (var item in rectangleList)
            {
                if (max < item.Square())
                {
                    max = item.Square();
                }
            }
            Console.WriteLine(max);*/
        }
    }
}
