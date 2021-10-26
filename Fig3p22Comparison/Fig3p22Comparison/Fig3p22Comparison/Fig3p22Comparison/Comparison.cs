using System;

namespace Fig3p22Comparison
{
    public class Comparison
    {
        // Main method begins execution of C# app
        public static void Main(string[] args)
        {
            int number1, number2; // declare int numbers to compare

            // prompt user and read first number
            Console.Write( "Enter first Integer:");
            number1 = Convert.ToInt32(Console.ReadLine());

            // prompt user and read second number
            Console.Write("Enter second Integer:");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
                Console.WriteLine( "{0} == {1}", number1, number2);

            if (number1 != number2)
                Console.WriteLine("{0} != {1}", number1, number2);

            if (number1 < number2)
                Console.WriteLine("{0} < {1}", number1, number2);

            if (number1 > number2)
                Console.WriteLine("{0} > {1}", number1, number2);

            if (number1 <= number2)
                Console.WriteLine("{0} <= {1}", number1, number2);

            if (number1 >= number2)
                Console.WriteLine("{0} >= {1}", number1, number2);

        } // end Main method

    } // end Comparison class

}// end namespace Fig3p22Comparison
