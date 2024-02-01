using System;
class Program
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
