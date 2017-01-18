using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task6_Test_
{
    class Program
    {
        public static void Ex6Scan1()
        {
            Point p = new Point();
            p.x = 127;
            p.y = 113;
            String str = p.print();
            Console.WriteLine(str);
        }

        public static void Ex6Scan2()
        {
            Point p = new Point();
            p.x = 31;
            p.y = 37;
            String str = p.print();
            Console.WriteLine(p.print());
        }

        public static void Ex6Scan3()
        {
            Point p = new Point();
            p.setCoordinates(5, 7);
            Console.WriteLine(p.print());
        }

        public static void Ex6Scan4()
        {
            Point p1 = new Point();
            p1.setCoordinates(23, 29);
            Console.WriteLine("Distance berween " + p1.print() + " to (0;0) is " + p1.distanceTo(0, 0));
        }

        public static void Ex6Scan5()
        {
            Point p1 = new Point();
            p1.setCoordinates(11, 13);
            Point p2 = new Point();
            p2.x = 17;
            p2.y = 19;
            Console.WriteLine("Distance berween " + p1.print() + " and " + p2.print() +" is " + p1.distanceTo(p2));
        }


        static void Main(string[] args)
        {
            Ex6Scan1();
            Ex6Scan2();
            Ex6Scan3();
            Ex6Scan4();
            Ex6Scan5();
        }
    }
}
