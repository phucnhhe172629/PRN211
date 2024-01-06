using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static List<int> GetPrimeNumbers(List<int> number)
        {
            List<int> Primes = new List<int>();
            foreach (int i in number)
            {
                if (CheckPrimeNumber(i)) Primes.Add(i);
            }
            return Primes;

            Boolean CheckPrimeNumber(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) { return false; }
                }
                return true;
            }
        }

        static void PrintPrimeNumbers(List<int> Primes)
        {
            if (Primes.Count != 0)
            {
                Console.Write("Prime in list:");
                foreach (int i in Primes)
                {
                    Console.Write($" {i}");
                }
            }
            else
            {
                Console.WriteLine("There are no Prime in list");
            }
        }

        static List<int> getNumberList(int n)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine($"Enter {n} number : ");
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            return numbers;
        }

        static void Main(string[] args)
        {
            //get number list
            List<int> numbers = getNumberList(10);
            //get Prime number list
            List<int> Primes = GetPrimeNumbers(numbers);
            //print out
            PrintPrimeNumbers(Primes);
            Console.ReadLine();
        }
    }
}
