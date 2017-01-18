using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task4
{
    class Program
    {
        public static void Scan01()
        {
            Point p1 = new Point();
            p1.x = 109;
            p1.y = 113;
            Point p2 = new Point();
            p2.x = 127;
            p2.y = 131;
            double dist = Point.distanceBetween(p1, p2);
            Console.WriteLine("{0:0.0000}", dist);
        }

        public static void Scan02()
        {
            Point p1 = new Point();
            p1.x = 137;
            p1.y = 139;
            Point p2 = new Point();
            p2.x = 139;
            p2.y = 149;
            Console.WriteLine("{0:0.0000}",Point.distanceBetween(p1, p2));
        }        

        static void Main(string[] args)
        {
            Scan01();
            Scan02();
            //Scen2();
           // Scen1();
        }
    }
}
