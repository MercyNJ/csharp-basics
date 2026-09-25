using System;

namespace CSharpBasics.Basic_Programs
{
    public class OddRange
    {
        public static List<int> OddNumbersRange(int start, int stop)
        {
            List<int> result = new List<int>();

            for (int i = start; i <= stop; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
