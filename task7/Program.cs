using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task7
{

    class Rectangle
    {
        string name;
        int x;
        int y;
        int width;
        int height;
        int radius;

        public Rectangle(string name1, string x1, string y1, string w1, string h1)
        {
            name = name1;
            x = Convert.ToInt32(x1);
            y = Convert.ToInt32(y1);
            width = int.Parse(w1);
            height = int.Parse(h1);
        }

        public int SquareRectangle()
        {
            return width * height;
        }
    }

    class Circle
    {
        string name;
        int x;
        int y;
        int r;

        public Circle(string name2, string x2, string y2, string r2)
        {
            name = name2;
            x = Convert.ToInt32(x2);
            y = Convert.ToInt32(y2);
            r = Convert.ToInt32(r2);
        }

        public double SquareCircle()
        {
            return Math.PI * (r * r);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1. Просим пользователя ввести номер считываемого файла
            Console.WriteLine("Vvedite nomer: ");
            int file_number = int.Parse(Console.ReadLine());

            //1.1 проверка на наличе файла
            if (!File.Exists("test" + file_number + ".csv"))
            {
                Console.WriteLine("error");
                return;
            }

            //2. Создание экземпляра класса StreamReader
            //В которой будем хранить всю инфу из файла
            StreamReader sr2 = new StreamReader("test" + file_number + ".csv");
            //2.1 Создание экземпляра rectangleList класса List для удобства работы "вроде как"
            List<Rectangle> rectangleList = new List<Rectangle>();
            List<Circle> circleList = new List<Circle>();

            //3. Запускаем цикл в котором будем разбивать файл по строкам
            // а так же переносить его в массив
            while (!sr2.EndOfStream)
            {
                //3.1 создаём строковую переменную, в которую записывается информация из файла
                string str = sr2.ReadLine();

                //3.2. теперь массив строк для того, чтобы потом разбить это всё на строки
                String[] temp = str.Split(';');

                if (temp[0]=="circle")
                {
                    //создаём экз класса circle и передаём ему аргументами значения
                    Circle circ = new Circle(temp[0], temp[1], temp[2], temp[3]);
                    circleList.Add(circ);
                }

                if (temp[0] == "rect")
                {
                    //создаём экз класса rectangle и передаём ему аргументами значения
                    Rectangle rect = new Rectangle(temp[0], temp[1], temp[2], temp[3], temp[4]);
                    rectangleList.Add(rect);
                }
                

            }

            //ОПРЕДЕЛЕНИЕ НА ПРЯМОУГОЛЬНИК, КРУГ


            double maxRect = rectangleList[0].SquareRectangle();
            double maxCircle = circleList[0].SquareCircle();

            foreach (var item in rectangleList)
            {
                if (maxRect < item.SquareRectangle())
                {
                    maxRect = item.SquareRectangle();
                }
            }

            foreach (var item in circleList)
            {
                if (maxCircle < item.SquareCircle())
                {
                    maxCircle = item.SquareCircle();
                }
            }

            if (maxCircle < maxRect)
            {
                Console.WriteLine("наибольшая площадь у фигуры rectangle = "+ maxRect);
            } else
                Console.WriteLine("наибольшая площадь у фигуры circle = " + maxCircle);
        }
        }
        
}
