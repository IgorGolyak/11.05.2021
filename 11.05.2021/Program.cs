using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._05._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число x3");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число y3");
            double y3 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("введите число x1");
            Console.WriteLine("введите число x4");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число y4");
            double y4 = Convert.ToDouble(Console.ReadLine());
            double a1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 * y2));
            double a2 = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 * y3));
            double a3 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 * y4));
            double a4 = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 * y1));
            double a5 = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 * y3));
            double p1 = (a1 * a2 * a5) / 2;
            double p2 = (a3 * a4 * a5) / 2;
            double s1 = Math.Sqrt(p1 * (p1 - a3) * (p1 - a4) * (p1 - a5));
            double s2 = Math.Sqrt(p1 * (p1 - a3) * (p1 - a4) * (p1 - a5));
            double s = s1 + s2;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
