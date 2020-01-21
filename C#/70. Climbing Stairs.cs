/*
 * Link: https://leetcode.com/problems/climbing-stairs/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 1) return n;
        
        var dp = new int[n + 1];
        Array.Fill(dp, 0);
        
        dp[0] = 1;
        for(var i = 1; i <= n; i++) {
            for (var step = 1; step <= 2; step++) {
                if (i - step >= 0) {
                    dp[i] += dp[i - step];
                }
            }
        }
        
        return dp[n];
    }
}