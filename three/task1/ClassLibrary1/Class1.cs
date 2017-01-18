using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calc
    {
        public static void task1(int a, int b) //за счет static можно вызвать сразу имя класса
        {
            if (a > b)
            {
                Console.WriteLine("первое больше");
            }
            else
            {
                Console.WriteLine("второе число больше");
            }
        }

        public static void task5(double a, double b)
        {
            if (a < 0 || b < 0)
            {
                Console.WriteLine("расстояние не может быть < 0");
                return;
            }
            if (a < b)
            {
                Console.WriteLine("Расстояние в футах меньше ");
            }
            else
            {
                Console.WriteLine("Расстояние в киломаетрах меньше ");
            }
        }
    }
}
