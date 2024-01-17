using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate
{
    //declaring a delegate
    public delegate void MyDelegate(string msg);
    class MyClass
    {
        public static void Print(string message) =>
            Console.WriteLine($"{message.ToUpper()}");
        public static void Show(string message) =>
            Console.WriteLine($"{message.ToLower()}");
        public static void Display(string message) =>
            Console.WriteLine($"{message}");
    }

    internal class Program
    {
        // MyDe1egate type parameter
        static void InvokeDelegate(MyDelegate dele, string msg) => dele(msg);
        static void Main(string[] args)
        {
            string msg = "Multicast Delegate";
            MyDelegate MyDele01 = MyClass.Print;
            MyDelegate MyDele02 = MyClass.Show;
            Console.WriteLine("***Combines MyDele01 + MyDele02***");
            MyDelegate MyDele = MyDele01 + MyDele02;
            MyDele(msg);
            Console.WriteLine("***Combines MyDele01 + MyDele02 + MyDele03***");
            MyDelegate MyDele03 = MyClass.Display;
            MyDele += MyDele03;
            MyDele(msg);
            Console.WriteLine("-----------------------");
            Console.WriteLine("***Remove MyDe1e02***");
            MyDele -= MyDele02;
            MyDele("Hello World !");
            Console.ReadLine();
        }
    }
}
