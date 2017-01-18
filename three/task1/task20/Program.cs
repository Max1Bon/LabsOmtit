using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20
{
    // класс круг
    public class Circle
    {
        public double Xc, Yc;
        public int r;
    }
    //класс прямоугольник
    public class Rectangle
    {
       public int Xp, Yp, h, w;

        // содержится ли круг в прямоугольнике
       public bool Contains(Circle krug)
       {
           if (krug.Xc - krug.r > Xp && krug.Xc + krug.r < Xp + w && krug.Xc - krug.r > Yp && krug.Xc + krug.r < Yp + h)
           {
               return true;
           }
           else return false;
       }
        //содержится ли прямоугольник в круго
        public bool CircleContains(Circle krug)
        {
            if (krug.Xc - krug.r < Xp && krug.Xc + krug.r < Xp + w && krug.Yc - krug.r < Yp && krug.Yc + krug.r > Yp + h)
            {
                return true;
            }
            else return false;
        }
        // проверка на 0 и на вхождение точки
       public bool Contains(int Yt, int Xt)
       {

           if (w <= 0 || h <= 0 || Yt < 0 || Xt < 0 || Yp < 0 || Xp < 0)
           {
               throw new Exception("error: ширина или высота должны быть > 0");

           }
           //проверка на вхождение точки
           if (((Xp + w) > Xt) && (Yp + h) > Yt)
           {
               return true;
           }
           else return false;
       }
    }
      public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle();
            Console.WriteLine("лежит ли точка внутри прямоугольника");

             Console.WriteLine("Введите координаты точки \nXт =");
            int xt = int.Parse(Console.ReadLine());
            Console.WriteLine("Yт =");
            int yt = int.Parse(Console.ReadLine());

            Console.WriteLine("В какой точке будет находится верх. левый угол прямоуголльника \nXп =");
            rec1.Xp = int.Parse(Console.ReadLine());
            Console.WriteLine("Yп =");
            rec1.Yp = int.Parse(Console.ReadLine());
            Console.WriteLine("Высота пряммоугольника = ");
            rec1.h = int.Parse(Console.ReadLine());
            Console.WriteLine("Ширина =");
            rec1.w = int.Parse(Console.ReadLine());
          

           try
            {
                if (rec1.Contains(yt, xt)==true)
                    Console.WriteLine("содержится");
                else Console.WriteLine("не содержится");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

