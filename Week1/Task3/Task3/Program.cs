using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static int[] Change(int[] nums)
        {
            int[] massiv = new int[nums.Length * 2];
            for (int i = 0, j = 0; i < nums.Length; i++, j++)
            {
                massiv[j] = nums[i];
                j++;
                massiv[j] = nums[i];

            }
            return massiv;
        } 
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] arr = s.Split();

            int[] a = new int[n];

            for (int i =0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);
            }

            Console.WriteLine();
            int[] massiv = Change(a);
            for(int i = 0; i < massiv.Length; i++)
            {
                Console.Write(massiv[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
