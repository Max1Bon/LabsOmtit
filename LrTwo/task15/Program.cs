using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            double cels, far;
            Console.WriteLine("температура по шкале Цельсия: ");
            cels = double.Parse(Console.ReadLine());
            far = (cels * 1.8) + 32;
            Console.WriteLine("температура по шкале Фаренгейта: "+far);
        }
    }
}
