using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task23
{
    class Point
    {
        public double Xt;
        public double Yt;
    }
    class Program
    {
        public static string ShowKoordinate(int a, int b, int c, int d, int e, int f, int h, int i)
        {
            return"Координаты: \"x1\":"+a+", "+"\"y1\": " + b + "; " + "\"x2\": " + c + ", " + "\"y2\": " + d + "; " + "\"x3\": " + e + ", " + "\"y3\": " + f + "; " + "\"x4\": " + h + ", " + "\"y4\": " + i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Определить координаты верхнего левого угла, ширину и высоту прямоугольника, образующегося при пересечении");
            int x, y, h, w, x1, y1, w1, h1, x2, y2, w2, h2;
            Console.Write("Верхний левый угол первого прямоугольника находится в точке (X1;Y1)\nВведите х1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("высота равна H1: ");
            h1 = int.Parse(Console.ReadLine());
            Console.Write("ширина равна W1: ");
            w1 = int.Parse(Console.ReadLine());
            Console.Write("Верхний левый угол второго прямоугольника находится в точке (X2;Y2)\nВведите х2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            y2 = int.Parse(Console.ReadLine());
            Console.Write("высота равна H2: ");
            h2 = int.Parse(Console.ReadLine());
            Console.Write("ширина равна W2: ");
            w2 = int.Parse(Console.ReadLine());


            if (x1 == x2 && y1 == y2 && (w2 + x2) > (w1 + x1) && (h1 + y1) > (y2 + h2))
            {
                x = x1;
                y = y1;
                h = h2;
                w = w1;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));

            }
            if (x2<x1 && y1>y2 && (x2+w2)>(x1+w1)&& (h1 + y1) > (h2 + y2))
            {
                x = x1;
                y = y1;
                w = w1;
                h = (h2 + y2) - y1;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            }
            else 
            if (x2 < x1 && (x1 + w1) > (x2 + w2) && y2 < y1 && (y2 + h2) > (y1 + h1))
            {
                x = x1;
                y = y1;
                w = (x2 + w2) - x1;
                h =h1;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            }
            else
            if (x2 < x1 && y2 > y1 && (x2 + w2) > x1 && (y2 + h2) > (y1 + h1))
            {
                x = x1;
                y = y2;
                w = (w2 + x2) - x1;
                h = (h1 + y1) - y2;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            }
            else
            if (x1 == x2 && y1 == y2 && h1 == h2 && w1 == w2)
            {
                x = x1;
                y = y1;
                w = w1;
                h = h1;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            } else

            if (x1 < x2 && (w2 + x2) > x2 && (w2 + x2) < (w1 + x1) && y2 > y1 && (y1 + h1) > (y2 + h2))
            {
                x = x2;
                y = y2;
                w = w2;
                h = h2;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            }
            else if (x2 > x1 && x2 < (x1 + w1) && y2 > y1 && y2 < (y1 + h1))
            {
                x = x2;
                y = y2;
                w = w1 - (x2 - x1);
                h = h1 - (y2 - y1);
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));

            }
            else
            if (x2 >= (x1 + w1) || (y2 > (y1 + h1)))
            {
                Console.WriteLine("Не пересекаются");
            }
            else
            if (x2 > x1 && (x2 + w2) > (x1 + w1) && y2 < y1 && (y2 + w2) > y1 && (y2 + w2) < (y1 + w1))
            {
                x = x2;
                y = y1;
                w = (w2 - x2);
                h = h2 - y1;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            } else
            if (x2 > x1 && x2 < (x1 + w1) && y2 > y1 && y2 < (y1 + h1) && (x2+w2)>(x1+w1))
            {
                x = x2;
                y = y2;
                w = w2;
                h = (y1 + h1) - y2;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            }
            else
            if (x2 > x1 && x2 < (x1 + w1) && y2 > y1 && y2 < (y1 + h1))
            {
                x = x2;
                y = y2;
                w = w2;
                h = (y1 + h1) - y2;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            }
            else if (x2 < x1 && (x2 + w2) > (w1 + x1) && y2 > y1 && (h2 + y2) < (y1 + h1))
            {
                x = x1;
                y = y2;
                w = w1;
                h = h2;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            }
            else if (x2 > x1 && x2 < (x1 + x1) && y2 > y1 && y2 < (y1 + h1))
            {
                x = x2;
                y = y2;
                w = (w1 + x) - x2;
                h = (y1 + h1) - y2;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            }
            else if (x2 < x1 && (x2 + w2) > x1 && (x1 + w1) > (x2 + w2) && y2 < y1 && (y2 + h2) > y1 )
            {
                x = x1;
                y = y1;
                w = (x2 + w2) - x1;
                h = (y2 + h2) - y1;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            }
            else if (x2 < x1 && (x2 + w2) > x1 && y2 > y1 && (y1 + h1) < y2)
            {
                x = x1;
                y = y2;
                w = (x2 + w2) - x1;
                h = h2;
                Console.WriteLine("{\"x\":" + x + ",\"y\":" + y + ",\"w\":" + w + ",\"h\":" + h + "}");
                Console.WriteLine(ShowKoordinate(x, y, (x + w), y, x, (y + h), (x + w), (y + h)));
            }
            
        }
    }
}
