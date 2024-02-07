// Problem Description : Find the contiguous non-empty subarray within an array, A of length N, with the largest sum.

using System;
class largest_sum
{
   public static void Main(string[] args)
    {
        int[] input = { 1, 2, 3, 4, -10 };
        int currentSum = input[0];
        int maxSum = input[0];

        for (int i = 1; i < input.Length; i++) {
            currentSum = Math.Max(input[i],currentSum + input[i]);
            maxSum = Math.Max(maxSum,currentSum);
        }
        Console.WriteLine("Output: " + maxSum);
    }
}
