using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task9_Test_
{
    class Program
    {
        public static void Ex9Scan1()
        {
            Interval range = new Interval();
            range.a = 5;
            range.b = 11;
            range.slide(7);
            Console.WriteLine("Интервал успешно изменен");
            Console.WriteLine(range.print());
        }

        public static void Ex9Scan2()
        {
            Interval range = new Interval();
            range.a = 17;
            range.b = 29;
            range.slide(-4);
            Console.WriteLine("Интервал успешно изменен");
            Console.WriteLine(range.print());
        }

        public static void Ex9Scan3()
        {
            Interval range = new Interval();
            range.a = 37;
            range.b = 31;
            try
            {
                range.slide(2);
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
            Ex9Scan1();
            Ex9Scan2();
            Ex9Scan3();    
        }
    }
}
