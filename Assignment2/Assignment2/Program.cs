using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int avg = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the number : ");
                int input = int.Parse(Console.ReadLine());
                avg = avg + input;
                
            }
            Console.WriteLine($"Average of numbers is {avg / 5}");
            Console.ReadLine();
           

        }
    }
}
