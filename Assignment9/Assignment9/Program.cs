using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double commision = 0.0 , netSal;
            Console.WriteLine("Enter the basic salary : ");
            double basicSal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter total sales amount : ");
            double salesA = double.Parse(Console.ReadLine());
            if((salesA >5000) && (salesA < 7500))
            {
                commision =  salesA * 0.03;
            }
            else if ((salesA > 7501) && (salesA < 10500))
            {
                commision = salesA * 0.08;
            }
            else if ((salesA > 10501) && (salesA < 15000))
            {
                commision= salesA * 0.11;
            }
            else if(salesA > 15000)
            {
                commision = salesA * 0.15;
            }
            netSal = basicSal + commision;
            Console.WriteLine($"Net salary is {netSal}");
            Console.WriteLine($"Commision earned is {commision}");
            Console.ReadLine();



        }
    }
}
