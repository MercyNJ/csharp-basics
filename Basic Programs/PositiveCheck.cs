using System;

namespace CSharpBasics.Basic_Programs
{
    public class PositiveCheck
    {
        public static void CheckPositive(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is Negative");
            }
            else
                Console.WriteLine($"{num} is zero");
        }
    }
}
