using System;

namespace Prob3p24OddOrEven
{
    public class OddOrEven
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int num, mod;

            Console.Write("Enter integer: ");
            num = Convert.ToInt32(Console.ReadLine());

            mod = num % 2;

            if (mod == 0)
                Console.WriteLine(num + " is even.");
            if (mod != 0)
                Console.WriteLine(num + " is odd.");

            if (num % 2 == 0)
                Console.WriteLine(num + " is even.");
            if (num % 2 != 0)
                Console.WriteLine(num + " is odd.");


        } // end Main
    } // end class OddOrEven
} // end namespace Prob3p24OddOrEven
