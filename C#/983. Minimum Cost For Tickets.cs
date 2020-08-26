/*
 * Link: https://leetcode.com/problems/minimum-cost-for-tickets/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        var set = new HashSet<int>(days);
        var n = days[days.Length - 1];
        var dp = new int[n + 1];
            
        for (var i = 1; i <= n; i++) {
            if (!set.Contains(i)) {
                dp[i] = dp[i - 1];
            }
            else {
                dp[i] = Math.Min(
                    dp[Math.Max(0, i - 1)] + costs[0],
                    Math.Min(
                        dp[Math.Max(0, i - 7)] + costs[1],
                        dp[Math.Max(0, i - 30)] + costs[2]
                    )
                );
            }
        }
        
        return dp[n];
    }
}