using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a charcter : ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("The Ascii value of '{0}' is '{1}'", ch, (int)ch);
            Console.ReadKey();        
        }
    }
}
