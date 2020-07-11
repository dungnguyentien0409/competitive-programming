/*
 * Link: https://leetcode.com/problems/sqrtx/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MySqrt(int x) {
        double left = 1, right = x;
        
        while(true) {
            var mid = Math.Floor((left + right) / 2);
            var square = mid * mid;
            
            if ((int)square == x 
               || (square < x && Math.Pow((mid + 1), 2) > x)) {
                return (int) mid;
            }
            
            if (square < x) left = mid + 1;
            else right = mid;
        }
        
        return 0;
    }
}