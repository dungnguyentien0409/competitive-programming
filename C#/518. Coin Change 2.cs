/*
 * Link: https://leetcode.com/problems/coin-change-2/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int Change(int amount, int[] coins) {
        var dp = new int[coins.Length + 1][];
        for (var i = 0; i <= coins.Length; i++) dp[i] = new int[amount + 1];
        
        dp[0][0] = 1;
        for (var i = 1; i <= coins.Length; i++) {
            dp[i][0] = 1;
            
            for (var j = 1; j <= amount; j++) {
                dp[i][j] = dp[i - 1][j] // not pick coin i
                    + (j - coins[i - 1] >= 0 ? dp[i][j - coins[i - 1]] : 0); // pick coins i
            }
        }
        
        return dp[coins.Length][amount];
    }
}