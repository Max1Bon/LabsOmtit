using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string s;
            Console.Write("Выполняются ли неравенства a<b<c. \nВведите a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = double.Parse(Console.ReadLine());
            
            try
            {
                s = Neravenstvo(a, b, c);
                Console.WriteLine(s);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static string Neravenstvo(double a, double b, double c)
        {
            if (a==0 && b==0 && c == 0)
            {
                throw new ArgumentException("Error: Попробуйте ещё раз");
            }
            if (a < b && b < c)
            {
                return "Выполняется";
            }
            else
            {
                return "Не выполняется";
            }
        }
    }
}
