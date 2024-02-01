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
