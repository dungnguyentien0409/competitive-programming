/*
 * Link: https://leetcode.com/problems/integer-break/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int IntegerBreak(int n) {
        if (n <= 1) return n;
        
        var dp = new int[n + 1];
        dp[1] = 1;
        
        for (var i = 2; i <= n; i++) {
            for (var j = 1; j < i; j++) {
                dp[i] = Math.Max(dp[i],
                    Math.Max(dp[j], j) * Math.Max(dp[i - j], i - j)
                );
            }
        }
        
        return dp[n];
    }
}