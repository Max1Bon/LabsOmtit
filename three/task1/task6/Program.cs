using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
           double v1, v2;
            v1 = double.Parse(Console.ReadLine());
            v2 = double.Parse(Console.ReadLine());
            v1 = (v1 * 1000) / 3600;
            if (v2 < 0 || v1 < 0)
            {
                Console.WriteLine("скорость должно быть > 0");
            }
            if (v1 > v2)
            {
                Console.WriteLine("V2(м / с) меньше V1(км / ч)" + v1);
            }
            else Console.WriteLine("V1 (км/ч) меньше V2 (м/с)" + v1);
        }
    }
}
