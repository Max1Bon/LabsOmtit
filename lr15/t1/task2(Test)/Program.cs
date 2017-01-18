using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task2_Test_
{
    class Program
    {
        public static void Ex2Scan1()
        {
            Point p1 = new Point();
            p1.x = 0;
            p1.y = 0;
            Point p2 = new Point();
            p2.x = 4;
            p2.y = 3;
            double dist = p1.distanceTo(p2);
            Console.WriteLine(dist);
        }

        public static void Ex2Scan2()
        {
            Point p1 = new Point();
            p1.x = 0;
            p1.y = 0;
            Point p2 = new Point();
            p2.x = 0;
            p2.y = 0;
            Console.WriteLine(p1.distanceTo(p2));
        }

        public static void Ex2Scan3()
        {
            Point p1 = new Point();
            p1.x = 19;
            p1.y = 23;
            Point p2 = new Point();
            p2.x = 11;
            p2.y = 13;
            Console.WriteLine("{0:0.0000}", p1.distanceTo(p2));
        }

        public static void Ex2Scan4()
        {
            Point p1 = new Point();
            p1.x = 11;
            p1.y = 23;
            Point p2 = null;
            try
            {
                Console.WriteLine(p1.distanceTo(p2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        static void Main(string[] args)
        {
            Ex2Scan1();
            Ex2Scan2();
            Ex2Scan3();
            Ex2Scan4();
        }
    }
}
