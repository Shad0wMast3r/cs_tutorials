using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingStringsandComments
{        
    ///<summary>
    ///Documentation comments go before a method or a class bro.
    ///IIT never taught me this FUCK YOU PROFESSOR BILLY YOU'RE A BITCH
    ///</summary>
    class Program //class

    {
        static void Main(string[] args) //Main Method
        {
            /*MULTIPLE LINES*/
            //Single Lines


            /*Lets format some strings*/
            Console.WriteLine("Lets demo formatting strings. Press enter to begin...");
            Console.ReadLine() ;
            Console.Clear();
            DemoSubstitutionStrings(); //method
            LeftAlign(); //method
            RightAlign(); //method
            FormatNumericalData(); //method
            StringDotFormat(); //method
         } //end of main
        
        /*Create a new method called DemoSubstitutionStrings();*/
        static void DemoSubstitutionStrings()
        {
            Console.Write("Substitution strings are easier to read than concatenation!\n------------------------------------------------------------\nWhat is your name: ");
            //Get some sweet precious data
            string userName = Console.ReadLine();
            Console.Write("What is your favorite color: ");
            string favoriteColor = Console.ReadLine();

            //Subsitution Strings are in curly braces, they always start with 0
            //Each subsituion strings is replaced by the values following the strings.
            Console.WriteLine("Hello {0}! Your favorite color is {1}.\nI am a big fan of the name {0}.\n",userName,favoriteColor);

            //We can also pass literals or variables
            Console.WriteLine("My favorite number is {0}", 8);
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }//end of DemoSubstitutionStrings

        /*The LeftAlign Method Starts Here!*/
        static void LeftAlign()
        {//beginning of LeftAlign Method
            Console.WriteLine("Put a comma and a negative number to left align. ex {0,-15\n------------------------------------------------------------");
            /*The code below will align all the names and everything*/
            string lineOutputFormat = "{0,-15}{1,-2}{2,-5}";
            Console.WriteLine(lineOutputFormat,"John Doe", "IL", "60638");
            Console.WriteLine(lineOutputFormat, "Andy Kukuc", "IL", "60465");
            Console.WriteLine(lineOutputFormat, "Regan Foxx", "CA", "90210");
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
            Console.Clear();
        }//end of LeftAlign Method

        /*The RightAlign Method Starts Here*/
        static void RightAlign()
        {
            Console.WriteLine("Put a comma and a negative number to left align. ex {0,9\n------------------------------------------------------------");
            /*Two things:
             * 1. We can store a format in a string for later
             * 2. We can use the : and format code to do things like currency format
             */
            string lineOutputFormat = "{0,-15}{1,9:C}"; //:C means format code (Currency Format)
            Console.WriteLine(lineOutputFormat, "A12345678", 5302.32);
            Console.WriteLine(lineOutputFormat, "A20085841", 27.32);

            //This one will overflow what what happens
            Console.WriteLine(lineOutputFormat,"A20859329",1232706.00); //more then 9 characters long
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }// end of RightAlign method

        /*FormatNumericalData method starts*/
        static void FormatNumericalData()
        {
            int num1 = 12345;
            Console.WriteLine("The value of 12345 in vairous formats:\n");
            Console.WriteLine("c format: {0:c}", num1);
            Console.WriteLine("d9 format: {0:d9}", num1);
            Console.WriteLine("f3 format: {0:f3}", num1);
            Console.WriteLine("n format: {0:n}", num1);
            Console.WriteLine("\n");

            //Notice that the upper or lowercasing for hex
            //Determines if letters are upper or lowercase
            Console.WriteLine("E format {0:E}", num1);
            Console.WriteLine("e format {0:e}", num1);

            int hex1 = 9999;
            Console.WriteLine("For Hex we will use 99999 to get some letters.");
            Console.WriteLine("X format: {0:X}", hex1);
            Console.WriteLine("x format: {0:x}", hex1);

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }// end of NumericalFormatData Method

        /*StringDotFormat method begins here*/
        static void StringDotFormat()
        {
            //string.Format() allows for substituin strings as well.
            //It retuns a string we can store for later
            string totalLine = string.Format("Total: {0:c}", 25.39); //returns a string.
            Console.WriteLine(totalLine);
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

    }// end of class
}//end of the world