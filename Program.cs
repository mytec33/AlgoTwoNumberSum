using System;
using System.Collections.Generic;

namespace AlgoTwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 3, 5, -4, 8, 11, 1, -1, 6 };
            //int[] numbers = { 4, 6 };
            int[] numbers = { 15 };
            const int target = 10;

            int[] result = TwoNumberSum(numbers, target);

            if (result != null)
            {
                Console.WriteLine($"Result: {result[0]},{result[1]}");
            }
            else
            {
                Console.WriteLine("No match found");
            }
        }

        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            HashSet<int> compliment = new HashSet<int>();

            foreach(int x in array)
            {
                int y = targetSum - x;
                if (compliment.Contains(y))
                {
                    return new int[] { x, y };
                }

                compliment.Add(x);
            }

            return new int[0];
        }
    }
}
