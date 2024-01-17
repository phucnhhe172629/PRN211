using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas_with_Standard_Query_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array of strings
            string[] names = { "David", "Jane", "Peter", "John", "Mark" };
            foreach (string item in names.OrderBy(s => s))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
