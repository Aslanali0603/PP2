using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Creation(string newpath)                         // Method to create
        {
            Directory.CreateDirectory(newpath);                      // Create new directory
            string filename = "school.txt";                          // our new file will be shcool.txt for exapmle
            newpath = Path.Combine(newpath, filename);               // combine direction and name 
            FileStream fs = File.Create(newpath);                    // create file and create filestream
            fs.Close();                                              // close and save filesream
            StreamWriter sw = new StreamWriter(newpath);             // create writer
            sw.Write("Mysyk is very pysyk!");                        // writing in txt
            sw.Close();                                              // save and close
            Copying(newpath);                                        // call method Copying
            Deleting(newpath);                                       // call method Deleting
        }
        public static void Copying(string newpath)
        {
            string target = @"C:\Users\Аслан\Desktop\PP2/HelloMyFriend!.txt";  // target path
            File.Copy(newpath, target);                                        // copying from source newpath to target path
        }
        public static void Deleting(string newpath)
        {
            File.Delete(newpath);                                              // deleting first file
        }
        static void Main(string[] args)
        {
            string newpath = @"C:\Users\Аслан\Desktop\PP2/local";            //Creating string which consists path
            Creation(newpath);                                               //call method to create
        }

     
        
    }
}
