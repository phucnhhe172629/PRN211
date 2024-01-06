using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Console_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            int i;
            string s;
            DateTime date;
            Console.WriteLine("***** Data Type Parsing");
            Console.Write("Enter a String value: ");
            s = Console.ReadLine();
            Console.Write("Enter a Double value: ");
            d = double.Parse(Console.ReadLine());
            Console.Write("Enter an Integer value: ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter a Date value: ");
            date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Value of s:{s}, i:{i}, d:{d}, date:{date:dd/MM/yyyy}");
            Console.ReadLine();
        }
    }
}
