using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Interval
    {
        public double a { private set; get; }
        public double b { private set; get; }

        public double lenght()
        {
            double l = b - a;
            return l;
        }

        //Создание конструктора, чтобы записать как-то так: Inteval(23,29)
        public Interval(double a1, double b1)
        {
            if (b1 < a1)
            {
                throw new Exception("Некорректный интервал");
            }
            a = a1;
            b = b1;
        }

        public double squeeze (double arg)
        {
            double z = 0;
            z = b - a;
            if (b < a)
            {
                throw new Exception("Некорректный интервал");
            }
            else if (arg <= z)
            {
                b = b - arg;
            } else if (arg > z)
            {
                throw new Exception("Невозможно умньшить интервал на указанную длину");
            }
            return b;
        }

        public double slide (double arg)
        {
            if (b < a)
            {
                throw new Exception("Некорректный интервал");
            }
            else if (arg < 0 || arg >0)
            {
                a = a + arg;
                b = b + arg;
                return b;
                
            }
            else return b;
        }

        public bool intersects(Interval r)
        {
            double a2 = r.a;
            double b2 = r.b;

            if (b < a || b2 < a2)
            {
                throw new Exception("Некорректный интервал");
            }
            else if (r == null)
            {
                throw new Exception("Данный интервал не инициализирован");
            }
            else if (a2 > a && b2 > a && a2 > b && b2 > b)
            {
                return false;
            }
            else if (a2 > a && a2 < b && b2 >a && b2 > b)
            {
                return true;
            } else if (a2 < a && a2 < b && b2 > a && b2 > b)
            {
                return true;
            }
            else if (a2 < a && a2 < b && b2 < a && b2 < b)
            {
                return false;
            }
            else return false;
        }

        public static bool areIntersect(Interval l, Interval r)
        {
            double a1 = l.a;
            double b1 = l.b;
            double a2 = r.a;
            double b2 = r.b;

            if (l.b < l.a || r.b < r.a)
            {
                throw new Exception("Некорректный интервал");
            }
            else if (a2 > a1 && b2 > a1 && a2 > b1 && b2 > b1)
            {
                return false;
            }
            else if (a2 > a1 && a2 < b1 && b2 > a1 && b2 > b1)
            {
                return true;
            }
            else if (a2 < a1 && a2 < b1 && b2 > a1 && b2 > b1)
            {
                return true;
            }
            else if (a2 < a1 && a2 < b1 && b2 < a1 && b2 < b1)
            {
                return false;
            }
            else return false;
        }

        public bool contains(int l)
        {
            if (b < a)
            {
                throw new Exception("Некорректный интервал");
            }
            if (l > a && l < b)
            {
                return true;
            }
            else return false;
        }

        public string print()
        {
            if (b < a)
            {
                throw new Exception("Некорректный интервал");
            }
            return "[" + a + ";" + b + "]";
        }
}

   public class Point
    {
        public double x;
        public double y;
       //конструктор
        public Point()
        {

        }
       //конструктор с параметрами
        public Point(int x1, int y1)
        {
            x = x1;
            y = y1;
        }
        public string print()
        {
            return "(" + x + ";" + y + ")";
        }

        public void setCoordinates(int x1, int y1)
        {
            x = x1;
            y = y1;
        }
       
       public double distanceTo(double x3, double y3)
        {
            double a = x3 - x;
            double b = y3 - y;
            double c = Math.Sqrt((a * a) + (b * b));
            return c;
        }

        public double distanceTo(Point p)
        {
            if (p == null)
            {
                throw new Exception("Конечная точка не инициализирована");
            }
            double a = p.x - x;
            double b = p.y - y;
            double c = Math.Sqrt((a * a) + (b * b));
            return c;
        }


        public static double distanceBetween(Point p1, Point p2)
        {
            double a = p1.x - p2.x;
            double b = p1.y - p2.y;
            double c = Math.Sqrt((a * a) + (b * b));
            return c;
        }

    }
}
