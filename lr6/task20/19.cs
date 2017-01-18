using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            public static void draw_square(int width)
            {
                if (width <= 0)
                return 0;

                for (int i = 0; i < width; ++i)
                {
                for (int j = 0; j < width; ++j)
                        printf("%c", i == 0 || i == width - 1 || j == 0 || j == width - 1 ? '*' : ' ');
                puts("");
                }

            }
        }
    }
}
