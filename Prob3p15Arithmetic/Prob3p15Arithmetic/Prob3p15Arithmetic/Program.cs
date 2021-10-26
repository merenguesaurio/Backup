using System;
/*
 * 3.15 (Arithmetic) Write an app that asks the user to enter two integers, 
 * obtains them from the user and displays their sum, product, difference 
 * and quotient (division). Use the techniques shown in Fig. 3.14.
 */
namespace Prob3p15Arithmetic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Enter first integer:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer:");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            int modulus = num1 % num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, product);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, difference);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, quotient);
            Console.WriteLine("{0} % {1} = {2}", num1, num2, modulus);


        }
    }
}
