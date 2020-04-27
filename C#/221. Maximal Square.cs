/*
 * Link: https://leetcode.com/problems/maximal-square/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaximalSquare(char[][] matrix) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return 0;
        
        int rows = matrix.Length, cols = matrix[0].Length;
        var dp = CreateDP(rows, cols);
        var res = 0;
        
        for (var i = 1; i <= rows; i++) {
            for (var j = 1; j <= cols; j++) {
                if (matrix[i - 1][j - 1] == '1') {
                    dp[i][j] = Math.Min(dp[i - 1][j - 1], Math.Min(dp[i - 1][j], dp[i][j - 1])) + 1;
                    res = Math.Max(res, dp[i][j]);
                }
            }
        }
        
        return res * res;
    }
    
    public int[][] CreateDP(int rows, int cols) {
        var dp = new int[rows + 1][];
        
        for(var i = 0; i <= rows; i++) {
            dp[i] = new int[cols + 1];
            
            for (var j = 0; j <= cols; j++) {
                dp[i][j] = 0;
            }
        }
        
        return dp;
    }
}