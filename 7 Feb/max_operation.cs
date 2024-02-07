//Problem Description : Little Ponny is given an array, A, of N integers. In a particular operation, he can set any element of the array equal to -1.He wants your help in finding out the minimum number of operations required such that the maximum element of the resulting array is B. If it is not possible, then return -1.

using System;
using System.Linq;
public class Operation
{
    public static void Main(string[] args)
    {
        int[] A = { 2, 3, 1, 4 };
        int B = 3;

        int maxElement = A.Max();
        if (maxElement <= B)
        {
            Console.WriteLine(0);
        }
        else
        {
        if (!A.Contains(B))
        {
            Console.WriteLine(-1);
        }
        else
        {
            int operations = A.Count(num => num > B);
            Console.WriteLine(operations);
        }
        }
    }
}
