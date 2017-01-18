using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task18
{
   public class Program
    {
        static void Main(string[] args)
        {
            int x;
            string s;
            x = int.Parse(Console.ReadLine());
            s = Schet(x);
        }
            
        public static string Schet(int x)
        {
            if ((x==2) || (x==6) || (x==7) || (x==8)||(x/26==1) || (x/26==1) || (x/40==1))
            {
                return x + "'ой";
            }
            else {
                if ((x == 1) || (x / 4 == 1) || (x % 5 == 0) || (x / 9 == 1) ||
                (x % 10 == 0) || (x % 10 == 1) || (x % 10 == 9) || (x % 10 == 4) ||
                (x % 10 == 5) || (x % 100 == 0) || (x % 100 == 4) || (x % 100 == 5) ||
                (x % 100 == 9) || (x % 100 % 10 == 0) || (x % 100 % 10 == 1) || (x % 100 % 10 == 2)||(x%10==8))
 
                {
                    return x + "'ый";
                }
                else if (x==3)
                {
                    return x + "'ий";
                } else 
                {
                    return x + "'1ый"; 
                }
            } 
            
               
            
                      
            }
        }   
    }

