using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName.ui
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the for the Users Name and ReadLine does magics
            Console.Write("What is your name? ");
            //Declare the String to Store Name
            string name = Console.ReadLine(); //the best way saves time and money
            //Print out message
            Console.WriteLine("Hello " + name);
            Console.ReadLine();
        }
    }
}
