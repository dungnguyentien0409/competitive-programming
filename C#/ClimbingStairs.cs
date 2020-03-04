// Problem: https://leetcode.com/problems/climbing-stairs/submissions/
// Author: Dung Nguyen Tien (Chris)

public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 2) return n;
        
        var dp = createDP(n);
        dp[1] = 1;
        dp[2] = 2;
        
        for (int i = 3; i <= n; i++) {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        
        return dp[n];
    }
    
    int[] createDP(int n) {
        var dp = new int[n + 1];
        
        for (int i = 0; i <= n; i++) dp[i] = 0;
        
        return dp;
    }
}