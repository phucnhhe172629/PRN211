﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables of main method
            int x = 1;
            int y = 2;
            // Local Function
            void AddValue(int a, int b)
            {
                Console.WriteLine("Value of a is: " + a);
                Console.WriteLine("Value of b is: " + b);
                Console.WriteLine("Value of x is: " + x);
                Console.WriteLine("Value of y is: " + y);
                Console.WriteLine();
            }
            // Calling Local function
            AddValue(3, 4);
            AddValue(5, 6);
            Console.ReadLine();
        }
    }
}
