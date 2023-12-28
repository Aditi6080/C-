using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double num1, num2, result;
            do
            {
                Console.WriteLine("Menu :");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter two numbers :");
                        num1 = double.Parse(Console.ReadLine());
                        num2 = double.Parse(Console.ReadLine());    
                        result = num1 + num2;
                        Console.WriteLine($"{result}");
                        break;

                    case 2:
                        Console.WriteLine("Enter two numbers :");
                        num1 = double.Parse(Console.ReadLine());
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 - num2;
                        Console.WriteLine($"{result}");
                        break;

                    case 3:
                        Console.WriteLine("Enter two numbers :");
                        num1 = double.Parse(Console.ReadLine());
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 * num2;
                        Console.WriteLine($"{result}");
                        break;

                    case 4:
                        Console.WriteLine("Enter two numbers :");
                        num1 = double.Parse(Console.ReadLine());
                        num2 = double.Parse(Console.ReadLine());
                        if(num2 == 0)
                        {
                            Console.WriteLine("Can not divide these numbers");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"{result}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting..");
                        break;

                        default: Console.WriteLine("Invalid choice..");

                        break;


                }
            } while(choice!=5);
        }
    }
}
