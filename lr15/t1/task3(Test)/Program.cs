using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task3_Test_
{

    class Program
    {
        public static void Ex3Scan2()
        {
            Interval l = new Interval();
            l.a = 11;
            l.b = 17;
            Interval r = new Interval();
            r.a = 13;
            r.b = 19;
            Console.WriteLine(l.intersects(r));
        }

        public static void Ex3Scan3()
        {
            Interval l = new Interval();
            l.a = 5;
            l.b = 15;
            Interval r = new Interval();
            r.a = 0;
            r.b = 30;
            Console.WriteLine(l.intersects(r));
        }

        public static void Ex3Scan4()
        {
            Interval l = new Interval();
            l.a = 67;
            l.b = 71;
            Interval r = new Interval();
            r.a = 59;
            r.b = 61;
            Console.WriteLine(l.intersects(r));
        }

        public static void Ex3Scan5()
        {
            Interval l = new Interval();
            l.a = 79;
            l.b = 73;
            Interval r = new Interval();
            r.a = 83;
            r.b = 89;
            try
            {
                Console.WriteLine(l.intersects(r));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void Ex3Scan6()
        {
            Interval l = new Interval();
            l.a = 97;
            l.b = 101;
            Interval r = new Interval();
            r.a = 107;
            r.b = 103;
            try
            {
                Console.WriteLine(l.intersects(r));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void Ex3Scan7()
        {
            Interval l = new Interval();
            l.a = 127;
            l.b = 131;
            Interval r = null;
            try
            {
                Console.WriteLine(l.intersects(r));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void Main(string[] args)
        {
            Ex3Scan1();
            Ex3Scan2();
            Ex3Scan3();
            Ex3Scan4();
            Ex3Scan5();
            Ex3Scan6();
            Ex3Scan7();
        }
    }
}
