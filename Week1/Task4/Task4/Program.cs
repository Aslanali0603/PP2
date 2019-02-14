using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] s = new string[100, 100];          // Declare 2d array

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    s[i, j] = "[*]";                    // filling array with [*]
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(s[i, j]);             // Output values
                }
                Console.WriteLine();                    // Output new line
            }
            Console.ReadKey();
        }

    }
}

