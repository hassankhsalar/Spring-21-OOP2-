using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the sum of first 100 odd even numbers:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("The first 100 odd even number are :\n");
            for (j = 1; j <= 100; j++)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
        }
    }
}
