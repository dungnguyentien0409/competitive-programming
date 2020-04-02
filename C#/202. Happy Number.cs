/*
 * Link: https://leetcode.com/problems/happy-number/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool IsHappy(int n) {
        var slow = n;
        var fast = digitSquareSum(n);
        
        while(slow != fast) {
            slow = digitSquareSum(slow);
            fast = digitSquareSum(digitSquareSum(fast));
        }
        
        if (slow == 1) return true;
        Console.WriteLine(slow);
        Console.WriteLine(fast);
        return false;
    }
    
    public int digitSquareSum(int n) {
        var sum = 0;
        
        while (n > 0) {
            var d = n % 10;
            sum += d * d;
            
            n = n / 10;
        }
        
        return sum;
    }
}