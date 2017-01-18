using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task5_Test_
{
    class Program
    {
        public static void Ex5Scan1()
        {
            Interval l = new Interval(2,3);
           
            Interval r = new Interval(5,7);
            r.a = 5;
            r.b = 7;
            Console.WriteLine(Interval.areIntersect(l, r));
        }

        public static void Ex5Scan2()
        {
            Interval l = new Interval();
            l.a = 11;
            l.b = 17;
            Interval r = new Interval();
            r.a = 13;
            r.b = 19;
            Console.WriteLine(Interval.areIntersect(l, r));
        }

        public static void Ex5Scan3()
        {
            Interval l = new Interval();
            l.a = 79;
            l.b = 73;
            Interval r = new Interval();
            r.a = 83;
            r.b = 89;
            try
            {
                Console.WriteLine(Interval.areIntersect(l, r));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void Ex5Scan4()
        {
            Interval l = new Interval();
            l.a = 97;
            l.b = 101;
            Interval r = new Interval();
            r.a = 107;
            r.b = 103;
            try
            {
                Console.WriteLine(Interval.areIntersect(l, r));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void Main(string[] args)
        {
            Ex5Scan1();
            Ex5Scan2();
            Ex5Scan3();
            Ex5Scan4();
        }
    }
}
