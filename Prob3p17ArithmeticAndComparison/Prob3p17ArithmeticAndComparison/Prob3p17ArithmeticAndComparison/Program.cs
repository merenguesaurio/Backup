using System;
/*
 * 3.17 (Arithmetic, Smallest and Largest) Write an app that inputs three 
 * integers from the user and displays the sum, average, product, and 
 * smallest and largest of the numbers. Use the techniques from Fig. 3.22. 
 * [Note: The average calculation in this exercise should result in an 
 * integer representation of the average. So, if the sum of the values is 
 * 7, the average should be 2, not 2.3333….]
 */
namespace Prob3p17ArithmeticAndComparison
{
    class ArithmeticAndComparison
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1, num2, num3, n = 3;

            Console.Write("Enter first integer number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third integer number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( "Sum is {0}", num1 + num2 + num3 );
            Console.WriteLine( "Average is {0}", (num1 + num2 + num3) / n );

            if (num1 >= num2)
            {
                if (num1 >= num3)
                    Console.WriteLine("Largest of the numbers {0}", num1);
                if (num1 < num3)
                    Console.WriteLine("Largest of the numbers is " + num3);
            }
            if (num1 < num2)
            {
                if (num2 >= num3)
                    Console.WriteLine("Largest of the numbers {0}", num2);
                if (num2 < num3)
                    Console.WriteLine("Largest of the numbers is " + num3);
            }


            if (num1 <= num2)
            {
                if (num1 <= num3)
                    Console.WriteLine("Smallest of the numbers {0}", num1);
                if (num1 > num3)
                    Console.WriteLine("Smallest of the numbers is " + num3);
            }
            if (num1 > num2)
            {
                if (num2 <= num3)
                    Console.WriteLine("Samllest of the numbers {0}", num2);
                if (num2 > num3)
                    Console.WriteLine("Smallest of the numbers is " + num3);
            }



        } // end Main
    } // end ArithmeticAndComparison
} // end namespace Prob3p17ArithmeticAndComparison
