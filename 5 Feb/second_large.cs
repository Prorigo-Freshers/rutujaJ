using System;

class Program
{
    public static void Main(string[] args)
    {
         int[] A = { 2, 1, 2 };
        int n = A.Length;

        if (n < 2) {
            Console.WriteLine("-1");
        }
        else{
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in A)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest){
                    secondLargest = num;
                }
            }

            if (secondLargest == int.MinValue){
                Console.WriteLine("-1");
            }
            else{
                Console.WriteLine(secondLargest);
            }
        }
    }
}
