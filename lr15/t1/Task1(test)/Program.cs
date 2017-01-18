using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task1_test_
{
    class Program
    {
        public static void Ex1Scan1()
        {
            Point p = new Point();
            p.x = 0;
            p.y = 0;
            double dist = p.distanceTo(4, 3);
            Console.WriteLine(dist);
        }

        public static void Ex1Scan2()
        {
            Point p = new Point();
            p.x = 0;
            p.y = 0;
            Console.WriteLine(p.distanceTo(0, 0));
        }

        public static void Ex1Scan3()
        {
            Point p = new Point();
            p.x = 19;
            p.y = 23;
            Console.WriteLine("{0:0.0000}",p.distanceTo(11, 13));
        }
        public static void Ex1Scan4()
        {
            Point p = new Point();
            p.x = 11;
            p.y = 23;
            Console.WriteLine(p.distanceTo(11, 13));
        }

        static void Main(string[] args)
        {
            Ex1Scan1();
            Ex1Scan2();
            Ex1Scan3();
            Ex1Scan4();
        }
    }
}
