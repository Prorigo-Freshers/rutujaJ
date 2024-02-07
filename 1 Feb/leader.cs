// Problem Description : Given an integer array A containing N distinct integers, you have to find all the leaders in array A. An element is a leader if it is strictly greater than all the elements to its right side. NOTE: The rightmost element is always a leader.



using System;
class leader
{
   public static void Main(string[] args)
    {
        int[] A = { 16, 17, 4, 3, 5, 2 };
        int n = A.Length;
      int maxRight = A[n - 1];
        Console.Write(maxRight + " ");
        for (int i = n - 2; i >= 0; i--)
        {
            if (A[i] > maxRight)
            {
                Console.Write(A[i] + " ");
                maxRight = A[i];
            }
        }
    }
}
