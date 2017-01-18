using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Дана длина ребра куба. Найти площадь его боковой поверхности по формуле S=6a2.
            Double c, x;
            String s;
            s = Console.ReadLine();
            x = Double.Parse(s);
            //исключение

            int w = 0;
            w = 4/w;
            try
            {
                c = task2(x);
                Console.WriteLine("результат: "+c);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static double task2(double a)
        {
            if (a<=0 )
            {
                throw new ArgumentException("ребро куба не может быть = или < 0");
            }
            return 6 * (a * a);
            
        }          
    }
}
