using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passing_Delegate_as_a_Parameter
{
    //declaring a delegate
    public delegate void MyDelegate(string msg);
    class MyClass
    {
        public static void Print(string message) =>
            Console.WriteLine($" {message.ToUpper()}");
        public static void Show(string message) =>
            Console.WriteLine($" {message.ToLower()}");
    }

    internal class Program
    {
        // MyDe1egate type parameter
        static void InvokeDelegate(MyDelegate dele, string msg) => dele(msg);
        static void Main(string[] args)
        {
            string msg = "Passing Delegate As A Parameter";
            InvokeDelegate(MyClass.Print, msg);
            InvokeDelegate(MyClass.Show, msg);
            Console.ReadLine();

        }
    }
}
