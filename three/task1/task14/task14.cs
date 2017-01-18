using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    public class task14
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("а: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = int.Parse(Console.ReadLine());
            try
            {
                String s = Ravnobedr(a, b, c);
                Console.WriteLine(s);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }

            public static string Ravnobedr(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("сторона должна быть > 0");
            }

            if (a == b || a == c || b == c)
            {
                return "Треугольник является равнобедренным.";
            }
            else return "Треугольник не является равнобедренным.";
        }
        }
    }
