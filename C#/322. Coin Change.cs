/*
 * Link: https://leetcode.com/problems/coin-change/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var dp = new int[amount + 1];
        Array.Fill(dp, Int32.MaxValue);
        
        dp[0] = 0;
        foreach(var c in coins) {
            for (var i = 1; i <= amount; i++) {
                if (i - c >= 0 && dp[i - c] != Int32.MaxValue) {
                    dp[i] = Math.Min(dp[i], dp[i - c] + 1);
                }
            }
        }
        
        return dp[amount] == Int32.MaxValue ? -1 : dp[amount];
    }
}