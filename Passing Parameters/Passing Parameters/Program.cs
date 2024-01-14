using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passing_Parameters
{
    internal class Program
    {
        static void MyMethod(int a, ref int b, out int c)
        {
            a = 3;
            b = 4;
            c = a + b;
        }

        static void SumArray(out int s, params int[] a)
        {
            s = 0;
            foreach (int i in a)
            {
                s += i;
            }
        }

        static int[] numbers = { 1, 2, 3, 4, 5 };
        static ref int FindNumber(int target)
        {
            bool flag = true;
            ref int value = ref numbers[0];
            for (int ctr = 0; ctr < numbers.Length && flag == true; ctr++)
            {
                if (numbers[ctr] == target)
                {
                    value = ref numbers[ctr];
                    flag = false;
                }
            }
            return ref value;
        }
        static void Main(string[] args)
        {
            int x = 1, y = 2, z;
            MyMethod(x, ref y, out z);
            Console.WriteLine($"x:{x}, y:{y}, z:{z}");

            int s;
            SumArray(out s, 1, 2, 3, 4);
            Console.WriteLine($"s={s}");
            int[] myIntArray = { 5, 6, 7, 8, 9 };
            SumArray(out s, myIntArray);
            Console.WriteLine($"s={s}");
            SumArray(out s);
            Console.WriteLine($"s={s}");

            Console.Write("Original sequence: ");
            Console.WriteLine(string.Join(" ", numbers));
            ref int value = ref FindNumber(3);
            value *= 2;
            Console.Write("New sequence:      ");
            Console.WriteLine(string.Join(" ", numbers));

            Console.ReadLine() ;
        }
    }
}
