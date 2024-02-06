using System;

class Program
{
    public static void Main(string[] args)
    {
       int[] input = { 9, 5, 6, 4, 1, 2, 7, 8 };
        int n = input.Length+1;
        int expectedSum = (n*(n+1))/2;
        int actualSum = 0;
        foreach (int num in input)
        {
            actualSum += num;
        }
        int missingNumber = expectedSum-actualSum;
        Console.WriteLine("Output: " + missingNumber);
    }
}
