//Problem Description : Given an array of integers A, every element appears twice except for one. Find that integer that occurs once.NOTE: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

using System;
class bitwise
{
    public static void Main(string[] args)
    {
     int[] input1 = { 1, 2, 2, 3, 1 };
     int[] input2 = { 1, 2, 2 };
      int result1 = 0;
      int result2 = 0;
        foreach (int n in input1){
            result1 ^= num;
        }       
        foreach (int n in input2){
            result2 ^= num;
        }
        Console.WriteLine("Output1: " + result1);
        Console.WriteLine("Output2: " + result2);
    }
}
