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
            if (x == 1) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
                if (x % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int a = 0;
            List<int> A_Prime = new List<int>();
            for (int i = 0; i < n; i++)
                if (Prime(int.Parse(s[i])))
                {
                    ++a;
                    A_Prime.Add(int.Parse(s[i]));
                }
            Console.WriteLine(a);
            foreach (int i in A_Prime)
                Console.Write(i + " ");
            Console.ReadKey();


        }
    }
}