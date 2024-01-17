using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 35;
            int n2 = 45;
            int result;
            // Using lambda expression to add two numbers
            Func<int, int, int> addNumber = (x, y) => x + y;
            result = addNumber(n1, n2);
            Console.WriteLine($"{n1} + {n2} = {result}");
            Console.ReadLine();
        }
    }
}
