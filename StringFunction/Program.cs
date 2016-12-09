using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abcdefwxyz";
           // Console.WriteLine(str.IndexOf('z'));
            int c = str.Length -1 - str.IndexOf('z');
            Console.WriteLine(c);

            Console.WriteLine(str.Substring(5, 2));
            Console.WriteLine(str.IndexOf('e', 7));
        }
    }
}
