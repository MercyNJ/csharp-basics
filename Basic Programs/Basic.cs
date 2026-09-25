using System;

namespace CSharpBasics.Basic_Programs
{
    public class Basic
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Back to the Basics");

            Console.WriteLine();
            EvenOdd.CheckNumber(27);

            //Range of odd numbers
            Console.WriteLine();
            List<int> odds = OddRange.OddNumbersRange(1, 10);
            Console.WriteLine("Odd numbers between 1 and 10:");
            Console.WriteLine(string.Join(", ", odds));

            //Positive check
            Console.WriteLine();
            PositiveCheck.CheckPositive(-1);

            Console.WriteLine();
            LargestOfTwo.FindLargest(10, 6);
        }
    }
}