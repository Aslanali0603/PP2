using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static int[] Change(int[] nums)                  // Method to duplicate every digit in arr
        {
            int[] massiv = new int[nums.Length * 2];            // Create new arr with double size
            for (int i = 0, j = 0; i < nums.Length; i++, j++)
            {
                massiv[j] = nums[i];                            // Giving value
                j++;
                massiv[j] = nums[i];

            }
            return massiv;                                      // returns given arr
        } 
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());                  // Enter size of arr and converting to int type
            string s = Console.ReadLine();                      // Input string to transfer
            string[] arr = s.Split();                           // Every element splitted by space

            int[] a = new int[n];                               // one dimensional arr with size n

            for (int i =0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);                       // initializing array a to int
            }

            Console.WriteLine();
            int[] massiv = Change(a);                           // Calling the function and give it our array, then it returns changed array
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write(massiv[i] + " ");                 // Output final array with spaces
            }
            Console.ReadKey();
        }
    }
}
