/*
 * Link: https://leetcode.com/problems/paint-fence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumWays(int n, int k) {
        if (n == 0) return 0;
        
        if (n == 1) return k;
        
        var dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = k;
        dp[2] = k * k;
        
        for (var i = 3; i <= n; i++) {
            dp[i] = dp[i - 1] * (k - 1) // i is different from i - 1
                + dp[i - 2] * (k - 1); //i is same as i - 1
        }
        
        return dp[n];
    }
}