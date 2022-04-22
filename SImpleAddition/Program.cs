using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImpleAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            //MATHS IN C#
            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine()); //Superiority
            Console.Write("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine()); //Superiority
            //int sum = num1 + num2; DEPRICATE
            Console.WriteLine("The sum is: "+(num1+num2)); //SUPERIOR
        }
    }
}
