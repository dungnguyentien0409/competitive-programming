/*
 * Link: https://leetcode.com/problems/count-square-submatrices-with-all-ones/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CountSquares(int[][] matrix) {
        var dp = CreateDP(matrix);
        var res = 0;
        
        for (var i = 1; i <= matrix.Length; i++) {
            for (var j = 1; j <= matrix[0].Length; j++) {
                if (matrix[i - 1][j - 1] == 1) {
                    dp[i][j] = Math.Min(dp[i - 1][j - 1], 
                        Math.Min(dp[i - 1][j], dp[i][j - 1])) + 1;
                    
                    res += dp[i][j];
                }
            }
        }
        
        return res;
    }
    
    public int[][] CreateDP(int[][] matrix) {
        var dp = new int[matrix.Length + 1][];
        
        for (var i = 0; i <= matrix.Length; i++) {
            dp[i] = new int[matrix[0].Length + 1];
        }
        
        return dp;
    }
}