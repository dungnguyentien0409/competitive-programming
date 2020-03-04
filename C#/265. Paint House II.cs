/*
 * Link: https://leetcode.com/problems/paint-house-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinCostII(int[][] costs) {
        if (costs.Length == 0 || costs[0].Length == 0) return 0;
        if (costs.Length == 1) return GetMin(costs[0]);
        
        int houses = costs.Length;
        int colors = costs[0].Length;
        var dp = CreateDP(colors);
        var current = CreateDP(colors);
        
        for (var i = 0; i < houses; i++) {
            for (var j = 0; j < colors; j++) {
                // if paint the current house with color j => calculate min fee
                current[j] = GetPreviousMin(dp, j) + costs[i][j];
            }
            
            Array.Copy(current, dp, colors);
        }
        
        return GetMin(dp);
    }
    
    public int GetPreviousMin(int[] dp, int pos) {
        var min = Int32.MaxValue;
        
        for (var i = 0; i < dp.Length; i++) {
            if (i != pos) {
                min = Math.Min(min, dp[i]);
            }
        }
        
        return min;
    }
    
    public int GetMin(int[] dp) {
        var min = Int32.MaxValue;
        
        for (var i = 0; i < dp.Length; i++) {
            min = Math.Min(min, dp[i]);
        }
        
        return min;
    }
    
    public int[] CreateDP(int color) {
        var dp = new int[color];
        Array.Fill(dp, 0);
        
        return dp;
    }
}