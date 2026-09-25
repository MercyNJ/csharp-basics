using System;

namespace CSharpBasics.Basic_Programs
{
    public class LargestOfTwo
    {
        public static void FindLargest(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is Largest");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} is Largest");
            }
            else
                Console.WriteLine($"{num1} is equal to {num2}");
        }
    }
}
