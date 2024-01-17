using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_Objects_with_Query_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array of strings
            string[] names = { "David", "Jane", "Peter", "John", "Mark" };
            var items = from word in names
                        where word.Contains("a")
                        select word;
            foreach (string s in items)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
