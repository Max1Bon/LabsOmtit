using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace task13_Test_
{
    class Program
    {
        public static void Ex13Scan1()
        {
            try
            {
                Interval range = new Interval(23, 29);
                Console.WriteLine("Интервал инициализирован");
                Console.WriteLine(range.print());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------------------------------");
        }

        public static void Ex13Scan2()
        {
            try
            {
                Interval range = new Interval(41, 29);
                Console.WriteLine("Интервал инициализирован");
                Console.WriteLine(range.print());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------------------------------");
        }
        
        public static void Ex13Scan3()
        {
            try
            {
                Interval range = new Interval(41, 29);
                Console.WriteLine("Интервал инициализирован");
                Console.WriteLine(range.print());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------------------------------");
        }

        public static void Ex13Scan4()
        {
            try
            {
                Interval range = new Interval(41, 29);
                Console.WriteLine("Интервал инициализирован");
                range.slide(20);
                Console.WriteLine("Интервал успешно изменен");
                Console.WriteLine(range.print());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------------------------------");
        }

        public static void Ex13Scan5()
        {
            try
            {
                Interval range = new Interval(211, 233);
                Console.WriteLine("Интервал инициализирован");
                range.squeeze(23);
                Console.WriteLine("Интервал успешно изменен");
                Console.WriteLine(range.print());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------------------------------");
        }

        public static void Ex13Scan6()
        {
            try
            {
                Interval range = new Interval(13, 151);
                Console.WriteLine("Интервал инициализирован");
                range.squeeze(41);
                Console.WriteLine("Интервал успешно изменен");
                Console.WriteLine(range.print()); 

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------------------------------");
        }

        public static void Ex13Scan7()
        {
            try
            {
                Interval range = new Interval(13, 151);
                Console.WriteLine("Длина интервала: " + range.lenght());
                range.squeeze(41);
                Console.WriteLine("Интервал успешно изменен");
                Console.WriteLine("Длина интервала: " + range.lenght());
                Console.WriteLine(range.print());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------------------------------");
        }
        static void Main(string[] args)
        {
            Ex13Scan1();
            Ex13Scan2();
            Ex13Scan3();
            Ex13Scan4();
            Ex13Scan5();
            Ex13Scan6();
            Ex13Scan7();

        }
    }
}
