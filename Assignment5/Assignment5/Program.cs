using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the value of a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b : ");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("The values of a:{0} and b{1}",a, b);
            Console.WriteLine(a+" "+b);
            Console.WriteLine($"{a},{b}");
            Console.WriteLine("{0},{1}",a,b);
            Console.ReadLine();        }
        


    }
}
