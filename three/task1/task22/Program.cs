using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    //класс -для создания объектов - полей, которые будут выводиться
    public class Interval
    {
        //создаются 2 переменные для вывода интервала
        public int a;
        public int b;
        // метод для вывода
        public  string print2()
        {
            return "(" + a + ", " + b + ")";
        }
    }

    public class Program
    {
        // метод для подсчета
        public static Interval calc(int a1, int b1, int a2, int b2) //метод с именем кальк и типом Interval
        {
            Interval range = new Interval(); //создали объект класса интервал

            if (a1 > b1 || a2 > b2)
            {
                throw new Exception("error: a  должно быть < b");
            }

            if (b2>a1 && b2<b1 && a2<a1)
            {
                range.a = a1;
                range.b = b2;
                return range;
            }
            else if (a1>a2 && b1<b2)
            {
                range.a = a1;
                range.b = b1;
                return range;
            }
            else if (a1 > a2 && a1 > b2 && b1 > a2 && b1 > b2)
            {
                return null;
            }
            

            if (a2 < b1)
            {
                if (b2 > b1)
                {
                    range.a = a2; //присваемваем полю а значение а1
                    range.b = b1;
                    return range; //возвращаем интервал
                }
                else
                {
                    range.a = a2;
                    range.b = b2;
                    return range;
                }

            }
            else
            {
                return null;
            }
        }
        
        //главный метод c выводом
        static void Main(string[] args)
        {
            Console.WriteLine("найти границы пересекающихся интервалов");
            int a1, b1, a2, b2;
            Console.WriteLine("первый интервал, где а1<b1 \na1 = ");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("b1 = ");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("второй интервал, где а2<b2 \na2 = ");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("b2 = ");
            b2 = int.Parse(Console.ReadLine());
            
            try
            {
               Interval range = calc(a1, b1, a2, b2);

                if (range != null)
                {
                    Console.WriteLine("Пересекается на " + range.print2());//range - объект
                }
                else Console.WriteLine("Не пересекаются");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

       /* public static int[] MassivDvuhChisel(int a1, int b1, int a2, int b2)
        {
            // метод с типом инт массив, и с именем массивдвухчисел
            int[] arr = new int[2];
            if (a1 > b1 || a2 > b2)
            {
               throw new Exception("error: a  должно быть < b");
            }

            if (a2 < b1)
            {
                if (b2 > b1) 
                {
                    arr[0] = a2;
                    arr[1] = b1;
                    return arr;
                }
                else
                    arr[0] = a2;
                arr[1] = b2;
                return arr; 
                
            }
            else
            {
                return null;
            }
        }*/
    }
}
