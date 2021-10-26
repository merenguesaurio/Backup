using System;

/*
 * 3.14 (Displaying Numbers) Write an app that displays the numbers 1 to 4 on
 * the same line, with each pair of adjacent numbers separated by one space. 
 * Write the app using the following techniques: 
 * a) Use one Console.WriteLine statement.
 * b) Use four Console.Write statements.
 * c) Use one Console.WriteLine statement with four format items.
 */
namespace Prob3p14DisplayingNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 2 3 4");
            Console.WriteLine("{0} {1} {2} {3}", 1, 2, 3, 4);
            Console.Write("{0} ", 1);
            Console.Write("{0} ", 2);
            Console.Write("{0} ", 3);
            Console.Write("{0} ", 4);
        }
    }
}
