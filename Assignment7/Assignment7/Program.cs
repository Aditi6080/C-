using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hra, da, pf, grossSal, netSal;
            Console.WriteLine("Enter your basic salary");
            double sal = double.Parse(Console.ReadLine());
            hra = sal * 0.2;
            da = sal * 0.4;
            grossSal = sal + hra + da;
            pf = grossSal * 0.1;
            netSal = grossSal - pf;
            Console.WriteLine($"Net salary is {netSal}");
            Console.ReadKey();
        }
    }
}




