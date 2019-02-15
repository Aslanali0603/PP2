using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void PrintSpaces(int level)                             // Method to print spaces
        {
            for (int i = 0; i < level; i++)                            // starts from 0 ends at level
                Console.Write(" ");                                    
        }

        static void GetInfo(DirectoryInfo directory, int level)        // Method with 2 parametres
        {
            FileInfo[] files = directory.GetFiles();                   // array files
            DirectoryInfo[] directories = directory.GetDirectories();  // array directories

            foreach(FileInfo file in files)                            // Check arr files
            {
                PrintSpaces(level);                                    // calls method PrintSpaces
                Console.WriteLine(file.Name);                          // outputs name of file
            }

            foreach(DirectoryInfo d in directories)                    // Check arr directories
            {
                PrintSpaces(level);                                    // Calls method PrintSpaces
                Console.WriteLine(d.Name);                             // Outputs name of directory
                GetInfo(d, level + 1);                                 // Calls method GetInfo with level++
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Аслан\Desktop\PP2\PP2\Week2"); // Gets directory info
            GetInfo(d, 0);                                                                // calls method GetInfo with level 0

        }
    }
}
