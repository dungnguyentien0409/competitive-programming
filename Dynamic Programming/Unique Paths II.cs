/*
 * Problem: https://leetcode.com/problems/unique-paths-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        if (obstacleGrid.Length == 0 || obstacleGrid[0].Length == 0 || obstacleGrid[0][0] == 1 || obstacleGrid[obstacleGrid.Length - 1][obstacleGrid[0].Length - 1] == 1)
            return 0;
        
        var rows = obstacleGrid.Length;
        var cols = obstacleGrid[0].Length;
        var dp = CreatDP(rows, cols);
        dp[0][0] = 1;
        
        for (var i = 1; i < rows; i++) {
            dp[i][0] = obstacleGrid[i - 1][0] == 0 ? dp[i - 1][0] : 0;
        }
        
        for (var j = 1; j < cols; j++) {
            dp[0][j] = obstacleGrid[0][j - 1] == 0 ? dp[0][j - 1] : 0;
        }
        
        for (var i = 1; i < rows; i++) {
            for (var j = 1; j < cols; j++) {
                if (obstacleGrid[i - 1][j] == 0) dp[i][j] += dp[i - 1][j];
                if (obstacleGrid[i][j - 1] == 0) dp[i][j] += dp[i][j - 1];
            }
        }
        
        return dp[rows - 1][cols - 1];
    }
    
    public int[][] CreatDP(int rows, int cols) {
        var dp = new int[rows][];
        
        for (var i = 0; i < rows; i++) {
            dp[i] = new int[cols];
            
            for (var j = 0; j < cols; j++) {
                dp[i][j] = 0;
            }
        }
        
        return dp;
    }
}