using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool Prime(int x)
        {
            if (x == 1) return false;                        // 1 is not prime
            for (int i = 2; i <= Math.Sqrt(x); i++)          // using Math and cheking for prime
                if (x % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());     // declare size of array
            string[] s = Console.ReadLine().Split();         // input arr
            int a = 0;                                       // how many primes counter
            List<int> A_Prime = new List<int>();             // declare simplest list of similar objects
            for (int i = 0; i < n; i++)
                if (Prime(int.Parse(s[i])))                  // check for a prime number
                {
                    ++a;                                     // if number is prime, add 1 for counter
                    A_Prime.Add(int.Parse(s[i]));            // if number is prime, add number in list
                }
            Console.WriteLine(a);                            // amount of prime numbers
            foreach (int i in A_Prime)                       // output each number from the list
                Console.Write(i + " ");
            Console.ReadKey();


        }
    }
}