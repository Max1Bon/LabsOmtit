using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class point
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = null;
            point p2 = new point();
            p2.x = 19;
            p1.y = 17;
            Console.WriteLine(p2.x + "," + p2.y);
        }
    }
}
