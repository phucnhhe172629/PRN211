using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuong_trinh_bac_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c;
            Console.Write("Input a = ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Input b = ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Input c = ");
            c = Double.Parse(Console.ReadLine());
            if (a != 0)
            {
                Double del = b * b - 4 * a * c;
                if (del < 0)
                {
                    Console.WriteLine("VN");
                }
                else if (del == 0)
                {
                    Console.WriteLine("x1 = x2 = " + (-b / (2 * a)));
                }
                else if (del > 0)
                {
                    Console.WriteLine("x1 = " + ((-b + Math.Sqrt(del)) / (2 * a)));
                    Console.WriteLine("x2 = " + ((-b - Math.Sqrt(del)) / (2 * a)));
                }
            }
            else
            {
                if (b != 0)
                {
                    Console.WriteLine("x = " + (-c / b));
                }
                else if (c == 0)
                {
                    Console.WriteLine("VSN");
                }
                else
                {
                    Console.WriteLine("VN");
                }
            }
            Console.ReadLine();
        }
    }
}
