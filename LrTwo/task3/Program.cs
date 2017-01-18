using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    // класс для вывода объема куба
    class VolumeKube
    {//поле класса
        public double v;
        //метод выводящий в консоль объем куба
        public string print1()
        { 
            return "обьем куба: " + v;
        }
    }

    class Program
    {
        // метод для подсчета объема куба
        public static VolumeKube calc(double longRib)
        {
            // Создаем объект типа VolumeKube
            VolumeKube range = new VolumeKube();
            range.v = Math.Pow(longRib, 3);
            return range;
        }

        static void Main(string[] args)
        {
            
            double a;
            Console.Write("длинна ребра: ");
            a = double.Parse(Console.ReadLine());
            VolumeKube volum = calc(a);
            Console.WriteLine(volum.print1());

        }
    }
}
