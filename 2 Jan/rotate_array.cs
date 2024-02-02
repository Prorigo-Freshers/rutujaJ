using System;

public class Solution
{
    public static void Main(string[] args)
    {
       int[] arr = { 1, 2, 3, 4 };
        Console.WriteLine("Original Array: " + string.Join(" ", arr));
        int B = 2;

        for (int i = 0; i < B; i++)
        {
            int lastElement = arr[arr.Length - 1];
            for (int j = arr.Length - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[0] = lastElement;
        }
      
        Console.WriteLine("Rotated Array: " + string.Join(" ", arr));
    }
}
