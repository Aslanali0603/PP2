using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    string name;
    string id;
    int year_of_study;

    Student(){}

    Student(string new_name,string new_id)
    {
        name = new_name;
        id = new_id;
    }
    string set_name(string new_name)
    {
        name = new_name;
        return name;
    }
    string set_id(string new_id)
    {
        id = new_id;
        return id;
    }
    int inc_year_of_study(int year)
    {
        year_of_study = year + 1;
        return year_of_study;
    }
}

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
