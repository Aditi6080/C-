using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the number : ");
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"sum of numbers is : {sum}");
            Console.ReadKey();
           

            
        }
    }
}
