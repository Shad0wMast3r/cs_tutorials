//Andy "shad0wMast3r" Kukuc
//The beginning of the end.
//Importing the Collection of Libraries (Namespaces)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ui 
{ //belongs to the containing statment
    class Program //class definition
    { //Class Members 
        static void Main(string[] args)//Main method. Also special because this is where it all starts
        {//methods are the verbs of programming.
            //Console.WriteLine("Hello World!"); //Print out the message
           //Console.ReadLine(); //Read the Users Input.


            //Types are a template for creating data structures.
            //Char represents always one character and are used with single quotes!'' not ""
            //Bool can only have two values true and false
            //Do not use Floats or Doubles for Money. ROUNDING ERRORS. ONLY USE DECIMAL
            string baby = "Fuck You!";
            sbyte num1 = -127;
            byte num2 = 255;
            int a = 5;
            int b = a + 2;
            bool test = true;
            //int c = a + test; WHAT ARE YOU DOING???? OF course it won't work just look at it.




            //Variables BABBYYY
            //Represents a Value.
            //Value changes but the name stays the same.
            //Memory and stuff.
            //Examples
            double var1 = 3.14;
            Console.Write(var1);
            byte sNumber = 5;
            string storm = "Thunderstorm";
            double temperature = 217.2;

            //declareing and assigning later;
            bool no;
            bool yes;
            no = false;
            yes = true;

            Console.Write(var1 + storm + temperature);
            int i = 500;
            double d = i; //implicit code
            short s = (short)i; //explicit code

            //Parsing the Bull
            string myStringNumber = "5"; 
            i = int.Parse(myStringNumber);

            //ERROR Runtime to be specific
            //string notNumber = "Bannana";
            //i = int.Parse(notNumber);

            //THE VAR
            var x = 10; //Implicit HOBO CODE
            int y = 10; //Explicit LEET CODE




            //Pretty much Java but in C and for Windows stuff. Java Suckss.
        }//Main method
    }//Class Members 
}//belongs to the containing statment