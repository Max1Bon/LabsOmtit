using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task7_Test_
{
    class Program
    {
        public static void Ex7Scan1()
        {
            Interval l = new Interval();
            l.a = 11;
            l.b = 17;
            Console.WriteLine(l.contains(0));
            Console.WriteLine(l.contains(15));
            Console.WriteLine(l.contains(200));
        }
        public static void Ex7Scan2()
        {
            Interval range = new Interval();
            range.a = 19;
            range.b = 17;
            try
            {
                Console.WriteLine(range.contains(18));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Ex7Scan1();
            Ex7Scan2();
        }
    }
}
