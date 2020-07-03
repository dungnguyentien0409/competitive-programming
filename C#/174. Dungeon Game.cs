/*
 * Link: https://leetcode.com/problems/dungeon-game/
 * Idea: DBabichev
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {
        int rows = dungeon.Length, cols = dungeon[0].Length;
        var dp = CreateDP(rows, cols);
        
        dp[rows - 1][cols] = 1;
        dp[rows][cols - 1] = 1;
        for (var i = rows - 1; i >= 0; i--) {
            for (var j = cols - 1; j >= 0; j--) {
                dp[i][j] = Math.Max(Math.Min(dp[i + 1][j], dp[i][j + 1]) - dungeon[i][j]
                                    , 1);
            }
        }
        
        
        return dp[0][0];
    }
    
    public int[][] CreateDP(int rows, int cols) {
        var dp = new int[rows + 1][];
        
        for (var i = 0; i <= rows; i++) {
            dp[i] = new int[cols + 1];
            
            Array.Fill(dp[i], Int32.MaxValue);
        }
        
        return dp;
    }
}