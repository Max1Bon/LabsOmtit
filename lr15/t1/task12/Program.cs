using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task12
{
    class Program
    {
        public static void Scan1()
        {
            Point p = new Point(53, 59);
            Console.WriteLine(p.print());
        }
        
        public static void Scan2()
        {
            Point p1 = new Point(53, 59);
            Point p2 = new Point(61, 67);
            Console.WriteLine("Distance between " + p1.print() + " and " + p2.print() + " is " +"{0:0.0000}", p1.distanceTo(p2));
        }
        public static void Scan3()
        {
            double dist = new Point(79, 83).distanceTo(new Point(89, 97));
            Console.WriteLine("{0:0.0000}", (dist));
        }

        public static void Scan4()
        {
            Point p = new Point(71, 73);
            Console.WriteLine("Distance between " + p.print()+ " to zero is " + "{0:0.0000}", p.distanceTo(new Point(0, 0)));
        }

        public static void Scan5()
        {
            Console.WriteLine("{0:0.0000}", new Point(79, 83).distanceTo(new Point(89, 97)));
        }

        public static void Scan6()
        {
            double dist = Point.distanceBetween(new Point(151, 157), new Point(163, 167));
            Console.WriteLine("{0:0.0000}", dist);
        }

        public static void Scan7()
        {
            Console.WriteLine("{0:0.0000}", Point.distanceBetween(new Point(173, 179), new Point(181, 191)));
        }

        static void Main(string[] args)
        {
           /* Scan1();
            Scan2();*/
            Scan3();
            /*Scan4();
            Scan5();
            Scan6();
            Scan7();*/
        }
    }
}
