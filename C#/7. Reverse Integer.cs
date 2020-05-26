/*
 * Link: https://leetcode.com/problems/reverse-integer/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int Reverse(int x) {
        int sign = x > 0 ? 1 : -1;
        long reverse = x > 0 ? x : -x;
        
        long val = x > 0 ? x : -x;
        while(val > 0) {
            reverse = reverse * 10 + val % 10;
            
            if (reverse > Int32.MaxValue) return 0;
            
            val /= 10;
        }
        
        return (int)reverse * sign;
    }
}