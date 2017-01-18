using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    class Line
    {
       public int x1, y1, x2, y2;

        public bool LineCalc(int x3, int y3)
        {
            int a = (y1 - y2) / (x1 - x2);
            int b = ((y1 + y2) - a * (x1 + x2)) / 2;
            if (x1 < 0 || y1 < 0 || x2 < 0 || y2 < 0 || x3 < 0 || y3 < 0)
            {
                throw new Exception("error: x or y need be > 0");
            }
            if (y3 == (a * x3 + b))
            {
                return true;
            }
            else return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line();

            int x3, y3, x1, y1, x2, y2;

            Console.WriteLine("принадлежит ли точка прямой");

            Console.WriteLine("Введите координаты точки \nx =");
            x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("y =");
            y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("первая точка отрезка \nx1 =");
            line1.x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("y1 =");
            line1.y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("вторая точка отрезка \nx2 = ");
            line1.x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("y2 =");
            line1.y2 = int.Parse(Console.ReadLine());

            try
            {
                if (line1.LineCalc(x3, y3)==true)
                {
                    Console.WriteLine("Точка принадлежит прямой");
                }
                else Console.WriteLine("Точка не принадлежит прямой");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
