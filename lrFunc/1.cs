using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lrFunc
{
    class Program
    {
        public static int GetX(int x, int b)
        {
            x = int.Parse(Console.ReadLine());
            b = 2 * x;
            return b;
        }

        static void Main(string[] args)
        {
            int a;
           int x = GetX(a);
        }
    }
}
