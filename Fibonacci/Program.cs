using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 1; 
            string fibString;
            int fibValue;

            Console.Write("Enter a number of the desired numbers in the Fibonacci sequence.");
            fibString = Console.ReadLine();
            bool res = int.TryParse(fibString, out fibValue);

            for (int i = 0; i < fibValue; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write(a + " ");
                Console.WriteLine();
            }
            
            Console.WriteLine("You've printed the first " + fibValue + " numbers of the Fibonacci sequence.");
            Console.ReadKey();
        }
    }
}
