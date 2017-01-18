using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sc, Ss, a, d;
            Sc = double.Parse(Console.ReadLine());
            Ss = double.Parse(Console.ReadLine());
            a = Ss / 4;
            d = Math.Sqrt((4 * Sc) / Math.PI);
            if (Sc < 0 || Ss < 0)
            {
                Console.WriteLine("площадь должна быть > 0");
            }
            if (a > d)
            {
                Console.WriteLine("Круг уместится в квадрате" + a + "  " + d);
            }
            else Console.WriteLine("Круг не поместится в квадрате");
        }
    }
}
