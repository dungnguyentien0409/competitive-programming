/*
 * Link: https://leetcode.com/problems/cherry-pickup/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: https://leetcode.com/problems/cherry-pickup/discuss/329945/Very-easy-to-follow-%3A-step-by-step-recursive-backtracking-with-memoization-N4.
*/

public class Solution {
    public int CherryPickup(int[][] grid) {
        // start from the same, so it can steps in to the visited sell
        int rows = grid.Length, cols = grid[0].Length;
        int?[,,,] dp = new int?[rows, cols, rows, cols];
        
        var cheries = Math.Max(0, CherryPickup(grid, 0, 0, 0, 0, dp));
        
        return cheries;
    }
    
    public int CherryPickup(int[][] grid, int r1, int c1, int r2, int c2, int?[,,,] dp) {
        int rows = grid.Length, cols = grid[0].Length;
        if (r1 >= rows || c1 >= cols
           || r2 >= rows || c2 >= cols
           || grid[r1][c1] == -1
           || grid[r2][c2] == -1) return Int32.MinValue;
        
        if (r1 == rows - 1 && c1 == cols - 1) return grid[r1][c1];
        if (r2 == rows - 1 && c2 == cols - 1) return grid[r2][c2];
        if (dp[r1,c1,r2,c2] != null) return (int)dp[r1,c1,r2,c2];
        
        int? cheries;
        if (r1 == r2 && c1 == c2) cheries = grid[r1][c1];
        else cheries = grid[r1][c1] + grid[r2][c2];
        
        cheries += Math.Max(
            Math.Max(CherryPickup(grid, r1 + 1, c1, r2 + 1, c2, dp),
                     CherryPickup(grid, r1 + 1, c1, r2, c2 + 1, dp)),
            Math.Max(CherryPickup(grid, r1, c1 + 1, r2 + 1, c2, dp),
                     CherryPickup(grid, r1, c1 + 1, r2, c2 + 1, dp))
        );
        
        return (int)(dp[r1,c1,r2,c2] = cheries);
    }
}