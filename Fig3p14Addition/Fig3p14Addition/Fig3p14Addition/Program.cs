using System;

namespace Fig3p14Addition
{
    public class Addition
    {
        // Main method begins execution of C# app
        public static void Main(string[] args)
        {
            int number1; // declare first number to add
            int number2; // decalre second number to add
            int sum; // declare sum of number1 and number2

            Console.Write( "Enter first integer: " ); // prompt user
            // read first number from user
            // string userNumber1 = Console.ReadLine();
            // number1 = Convert.ToInt32( userNumber1 );

            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: "); // prompt user
            // read second number from user
            // string userNumber2 = Console.ReadLine();
            // number2 = Convert.ToInt32(userNumber2);

            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2; // add numbers

            //Console.WriteLine("Sum is {0}", sum); // display sum

            Console.WriteLine("Sum is {0}", number1 + number2); // display sum

        }// end Main method

    }// end Addition class

}// end Fig3p14Addition namespace
