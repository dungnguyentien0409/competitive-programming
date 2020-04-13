/*
 * Link: https://leetcode.com/problems/number-of-ways-to-paint-n-3-grid/
 * Author: Dung Nguyen Tien (Chris)
 * Idea: Reference lee215
*/

public class Solution {
    public int NumOfWays(int n) {
        long a121 = 6, a123 = 6, MAX = (long)Math.Pow(10, 9) + 7;
        
        long b121, b123;
        for (var i = 1; i < n; i++) {
            b121 = a121 * 3 + a123 * 2;
            b123 = a121 * 2 + a123 * 2;
            
            a121 = b121 % MAX;
            a123 = b123 % MAX;
        }
        
        return (int)((a121 + a123) % MAX);
    }
}