/*
 * Link: https://leetcode.com/problems/minimum-falling-path-sum/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinFallingPathSum(int[][] A) {
        int rows = A.Length, cols = A[0].Length;
        var dp = CreateDP(rows, cols);
        
        dp[0][0] = 0;
        for(var i = 1; i <= rows; i++) {
            for (var j = 1; j <= cols; j++) {
                dp[i][j] = Math.Min(dp[i - 1][j], dp[i - 1][j - 1]);
                
                if (j < cols) dp[i][j] = Math.Min(dp[i][j], dp[i - 1][j + 1]);
                
                dp[i][j] += A[i - 1][j - 1];
            }
        }
        
        
        var min = Int32.MaxValue;
        for(var j = 1; j <= cols; j++) min = Math.Min(min, dp[rows][j]);
        
        return min;
    }
    
    public int[][] CreateDP(int rows, int cols) {
        var dp = new int[rows + 1][];
        
        for(var i = 0; i <= cols; i++) {
            dp[i] = new int[cols + 1];
            dp[i][0] = Int32.MaxValue;
        }
        
        Array.Fill(dp[0], 0);
        
        return dp;
    }
}