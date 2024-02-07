//Problem Description : Given an integer x, return true if x is a palindrome, and false otherwise.
using System;

public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 &&  x != 0) {
            return false;
        }
        
        int reversedNum = 0;
        int originalNum = x;
        
        while (x > 0) {
            int digit = x % 10;
            reversedNum = reversedNum * 10 + digit;
            x /= 10;
        }
        
        return originalNum == reversedNum;
    }
}

class Program {
    static void Main() {
        var solution = new Solution();
        Console.WriteLine(solution.IsPalindrome(919));   
        Console.WriteLine(solution.IsPalindrome(-121));  
        Console.WriteLine(solution.IsPalindrome(10));   
    }
}
