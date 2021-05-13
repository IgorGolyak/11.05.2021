using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число m1");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число m2");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число v1");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число v2");
            double v2 = Convert.ToDouble(Console.ReadLine());
            double p1 = m1 / v1;
            double p2 = m2 / v2;
            if (p1 > p2)
            {
                Console.WriteLine("Плотность 1 больше");
            }
            else if (p1 < p2)
            {
                Console.WriteLine("Плотность 2 больше");
            }
            Console.ReadKey();
        }
    }
}
