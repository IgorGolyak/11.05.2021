using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 237;
            int a = x / 100;
            int b = x % 100;
            x = b * 10 + a;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
