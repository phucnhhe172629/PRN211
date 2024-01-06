using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //get number
                (int a, int b) numbers = getNumber();
                //get operation
                int oper = getOperation();
                //Get result
                getResult(numbers, oper);
            }
        }

        private static void getResult((int a, int b) numbers, int oper)
        {
            switch (oper)
            {
                case 1:
                    Console.WriteLine($"{numbers.a} + {numbers.b} = {numbers.a + numbers.b}");
                    break;
                case 2:
                    Console.WriteLine($"{numbers.a} - {numbers.b} = {numbers.a - numbers.b}");
                    break;
                case 3:
                    Console.WriteLine($"{numbers.a} * {numbers.b} = {numbers.a * numbers.b}");
                    break;
                case 4:
                    Console.WriteLine($"{numbers.a} / {numbers.b} = {numbers.a / numbers.b}");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }

        private static int getOperation()
        {
            Console.WriteLine("Choose operation:\r\n" +
                "1 - Addition\r\n" +
                "2 - Subtraction\r\n" +
                "3 - Multiplication\r\n" +
                "4 - Division\r\n" +
                "0 - Exit\r\n");
            return int.Parse(Console.ReadLine());
        }

        private static (int a, int b) getNumber()
        {
            Console.Write("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            int b = int.Parse(Console.ReadLine());
            return (a, b);
        }
    }
}
