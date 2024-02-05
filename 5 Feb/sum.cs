using System;

class Program
{
    public static void Main(string[] args)
    {
        int N = 10;
        int sum = 0;
        for(int i = 1; i <= N; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}
