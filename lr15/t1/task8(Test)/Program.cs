using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task8_Test_
{
    class Program
    {
        public static void Ex8Scan1()
        {
            Interval range = new Interval();
            range.a = 23;
            range.b = 29;
            Console.WriteLine(range.print());
        }

        public static void Ex8Scan2()
        {
            Interval range = new Interval();
            range.a = 31;
            range.b = 29;
            try
            {
                Console.WriteLine(range.print());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            Ex8Scan1();
            Ex8Scan2();

        }
    }
}
