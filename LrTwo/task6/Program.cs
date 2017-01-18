using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            double s, a, h;
            Console.Write("основание: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("высота: ");
            h = double.Parse(Console.ReadLine());

            try
            {
                s = task6(a, h);
                Console.WriteLine("площадь = " + s);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);

            }
            finally { Console.WriteLine("задача решена"); }
        }

        public static double task6(double x, double y)
        {
            if (x<=0 || y<=0)
            {
                throw new ArgumentException("ошибка. х и у должны быть > 0");
            }
            return x * y / 2;
            
        }
    }
}
