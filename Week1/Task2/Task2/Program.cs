using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student                                 // create a class with new 3 types
{
    string name;
    string id;
    int year_of_study;

    Student(){}                              // default constructor with 0 parameters and without body

    Student(string new_name,string new_id)   // constructor with 2 parameters
    {
        name = new_name;
        id = new_id;
    }
    string set_name(string new_name)         // method to change name
    {
        name = new_name;
        return name;                         // returns name
    }
    string set_id(string new_id)             // method to change id
    {
        id = new_id;
        return id;                           // returns id
    }
    int inc_year_of_study(int year)          // method which add +1 to year_of_study and we get new year
    {
        year_of_study = year + 1;
        return year_of_study;                // returns year_of_study
    }
}

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
                                             // function main is emty because i need to work only with class Student
        }
    }
}
