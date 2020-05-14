/*
 * Link: https://leetcode.com/problems/min-cost-climbing-stairs/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var dp = new int[cost.Length + 1];
        dp[1] = cost[0];
        dp[2] = cost[1];
        
        for (var i = 3; i <= cost.Length; i++) {
            dp[i] += Math.Min(dp[i - 1], dp[i - 2]) + cost[i - 1];
        }
        
        return Math.Min(dp[cost.Length], dp[cost.Length - 1]);
    }
}