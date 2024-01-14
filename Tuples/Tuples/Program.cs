using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Program
    {
        static (int sum, int count) MyMethod(int[] value)
        {
            var r = (sum: 0, count: 0);
            for (int i = 0; i < value.Length; i++)
            {
                if (IsEvenNumber(value[i]))
                {
                    r.sum += value[i];
                    r.count++;
                }
            }
            return r;
            bool IsEvenNumber(int n)
            {
                return (n % 2 == 0);
            }
        }
        static void Main(string[] args)
        {
            (string MyString, int MyNumber) MyValue = ("Hello World!", 2025);
            Console.WriteLine($"MyString: {MyValue.MyString}");
            Console.WriteLine($"MyNumber: {MyValue.MyNumber}");

            int[] numbers = { 2, 1, 5, 6, 3, 4, 7, 8, 10, 9 };
            var (sum, count) = MyMethod(numbers);
            Console.WriteLine($"Sum: {sum}, Count: {count}");
            Console.ReadLine();
        }
    }
}
