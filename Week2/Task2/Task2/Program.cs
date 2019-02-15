using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Аслан\Desktop\PP2/Input.txt");  // Create a reader
            string[] s = sr.ReadToEnd().Split();                                          // Read a txt file
            StreamWriter sw = new StreamWriter(@"C:\Users\Аслан\Desktop\PP2/Output.txt"); // Create a writer
            for(int i = 0; i < s.Length;i++)
                if(Aprime(int.Parse(s[i])))                                               // Checking for prime
                {
                    sw.Write(s[i] + " ");                                                 // sending prime with spaces
                }
            sw.Close();                                                                   // and close for ennding and save primes


        }

        public static bool Aprime(int num)                                                // boolean function to check primes
        {
             if(num == 1)                                                                 // 1 is not prime 
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)                                     // starts from 2 ends at square root
                if (num % i == 0)                                                         
                    return false;                                                         // not primes 
            return true;                                                                  // primes
        }
    }
}
