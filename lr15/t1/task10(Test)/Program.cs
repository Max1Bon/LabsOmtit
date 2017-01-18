using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task10_Test_
{
    class Program
    {
        public static void Ex10Scan1()
        {
            Interval range = new Interval();
            range.a = 31;
            range.b = 37;
            try
            {
                range.squeeze(2);
                Console.WriteLine("Интервал успешно изменен");
                Console.WriteLine(range.print());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Ex10Scan2()
        {
            Interval range = new Interval();
            range.a = 41;
            range.b = 43;
            try
            {
                range.squeeze(19);
                Console.WriteLine("Интервал успешно изменен");
                Console.WriteLine(range.print());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Ex10Scan3()
        {
            Interval range = new Interval();
            range.a = 101;
            range.b = 67;
            try 
            {
                range.squeeze(23);
                Console.WriteLine("Интервал успешно изменен");
                Console.WriteLine(range.print());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            Ex10Scan1();
            Ex10Scan2();
            Ex10Scan3();
        }
    }
}
