/*
 * Link: https://leetcode.com/problems/paint-house/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinCost(int[][] costs) {
        if (costs.Length == 0) return 0;
        
        var houses = costs.Length;
        int colors = 3;
        var dp = CreateDP(houses, colors);
        
        for (var i = 1; i <= houses; i++) {
            // paint with red
            dp[i][0] = Math.Min(dp[i - 1][1], dp[i - 1][2]) + costs[i - 1][0];
            // paint with blue
            dp[i][1] = Math.Min(dp[i - 1][0], dp[i - 1][2]) + costs[i - 1][1];
            // paint with green
            dp[i][2] = Math.Min(dp[i - 1][0], dp[i - 1][1]) + costs[i - 1][2];
        }
        
        return Math.Min(dp[houses][0], Math.Min(dp[houses][1], dp[houses][2]));
    }
    
    public int[][] CreateDP(int houses, int colors) {
        var dp = new int[houses + 1][];
        
        for (var i = 0; i <= houses; i++) {
            dp[i] = new int[colors];
            for (var j = 0; j < colors; j++) {
                dp[i][j] = 0;
            }
        }
        
        return dp;
    }
}