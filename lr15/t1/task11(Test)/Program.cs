using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task11_Test_
{
    class Program
    {
        public static void Ex11Scan1()
        {
            Point p = new Point();
            p.x = 31;
            p.y = 37;
            Console.WriteLine(p.print());
        }

        public static void Ex11Scan2()
        {
            Point p = new Point();
            p.setCoordinates(5, 7);
            Console.WriteLine(p.print());
        }

        public static void Ex11Scan3()
        {
            Point p1 = new Point();
            p1.setCoordinates(23, 29);
            Console.WriteLine("Distance between " + p1.print() + " to (0;0) is " + p1.distanceTo(0, 0));
        }

        public static void Ex11Scan4()
        {
            Point p1 = new Point();
            p1.setCoordinates(11, 13);
            Point p2 = new Point();
            p2.x = 17;
            p2.y = 19;
            Console.WriteLine("Distance between " + p1.print()
                + " and " + p2.print() + " is " + p1.distanceTo(p2));
        }
        static void Main(string[] args)
        {
            Ex11Scan1();
            Ex11Scan2();
            Ex11Scan3();
            Ex11Scan4();
        }
    }
}
