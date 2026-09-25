using System;

namespace CSharpBasics.Basic_Programs
{
    public class EvenOdd
    {
        // Method that checks if the number is even or odd
        public static void CheckNumber(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even");
            }
            else
                Console.WriteLine($"{number} is Odd");
        }
    }
}