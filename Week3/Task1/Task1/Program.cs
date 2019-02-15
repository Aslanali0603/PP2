using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle
{
    int a;
    int b;
    int c;

    Triangle() { }
    public Triangle(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public int Perimetr()
    { 
        int p = a + b + c;
        return p;
    }
    public double Square()
    {
        double p = ((a + b + c)/2);

        return Math.Sqrt(p * (p - a) * (p - b)*(p - c));
    }
    
}
namespace Task1
{
}
    class Program
    {
        static void Main(string[] args)
        {
        tr1 = new tr1;
        
        }
    }
