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
            StreamReader sr = new StreamReader(@"C:\Users\Аслан\Desktop\PP2/FirstTimeGirl.txt");
            string s = sr.ReadToEnd();
            bool t = true;
            for (int i = 0; i < s.Length; i++)
                if (s[i] != s[s.Length - 1 - i])
                    t = false;
            if (t)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
