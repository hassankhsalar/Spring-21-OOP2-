using System;

namespace lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n =5 , sum = 0;

            Console.Write("\n\n");
            Console.Write("show even number:\n");
            Console.Write("###########################################");
            Console.Write("\n\n");

            Console.Write("\nThe even numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i);
                sum += 2 * i;
            }
        }
    }
}
