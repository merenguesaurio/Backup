using System;

/*
 * 3.16 (Comparing Integers) Write an app that asks the user to enter two 
 * integers, obtains them from the user and displays the larger number 
 * followed by the words "is larger" . If the numbers are equal, display the 
 * message "These numbers are equal . " Use the techniques shown in 
 * Fig. 3.22.
 */

namespace Prob3p16Comparison
{
    class Comparison
    {
        public static void Main(string[] args)
        {
            int num1, num2;

            // prompt user for first integer
            Console.Write("Enter first integer:");
            num1 = Convert.ToInt32(Console.ReadLine());

            // prompt user for second integer
            Console.Write("Enter first integer:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("These numbers are equal");
            if (num1 > num2)
                Console.WriteLine("{0} is larger", num1);
            if (num1 < num2)
                Console.WriteLine("{0} is larger", num2);



        } // end Main
    } // end Comparison class
} // end namespace Prob3p16Comparison
