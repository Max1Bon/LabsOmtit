using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, pass, host, port, db;
            Console.Write("user: ");
            user = Console.ReadLine();
            Console.Write("pass: ");
            pass = Console.ReadLine();
            Console.Write("host: ");
            host = Console.ReadLine();
            Console.Write("port: ");
            port = Console.ReadLine();
            Console.Write("db: ");
            db = Console.ReadLine();
            Console.WriteLine("User ID="+user+";Password="+pass+";Host="+host+";Port="+port+";Database="+db+";");
        }
    }
}
