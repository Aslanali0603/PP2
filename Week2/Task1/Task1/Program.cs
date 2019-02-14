using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Аслан\Desktop\PP2/Input.txt"); // From where we read
            string s = sr.ReadToEnd();                                                   // Read a txt file
            bool t = true;                                                               // create boolean for check
            for (int i = 0; i < s.Length/2; i++)                                           
                if (s[i] != s[s.Length - i - 1])                                         // Check for polindrom or not
                    t = false;
            if (t)                                                                       // If it is polindrom, output "Yes"
                Console.WriteLine("Yes");                                               
            else                                                                         // If it is not polindrom, output "No"
                Console.WriteLine("No");                                            
        }
    }
}