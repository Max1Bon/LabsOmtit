using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Double t, l, rslt1, rslt2;
            Console.Write("введите кол-во метров материала: ");
            t = double.Parse(Console.ReadLine());
            Console.Write("количество материала на 1 изделие: ");
            l = double.Parse(Console.ReadLine());
            rslt1 = t / l;
            rslt2 = t % l;
            Console.WriteLine("всего изделий: {0:0}", rslt1);
            Console.WriteLine("остаток: "+ rslt2 +" метр");
        }
    }
}
