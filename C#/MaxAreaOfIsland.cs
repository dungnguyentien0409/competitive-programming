/*
 * Problem: https://leetcode.com/problems/max-area-of-island/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        if (grid.Length == 0 || grid[0].Length == 0) return 0;
        
        var rows = grid.Length;
        var cols = grid[0].Length;
        var f_area = 0;
        var area = 0;
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    area = CalculateArea(grid, i, j);
                    f_area = Math.Max(area, f_area);
                }
            }
        }
        
        return f_area;
    }
    
    public int CalculateArea(int[][] grid, int x, int y) {
        if (x < 0 || y < 0 
           || x >= grid.Length || y >= grid[0].Length
           || grid[x][y] == 0)
            return 0;
        
        grid[x][y] = 0;
        
        return 1 
            + CalculateArea(grid, x - 1, y)
            + CalculateArea(grid, x + 1, y)
            + CalculateArea(grid, x, y - 1)
            + CalculateArea(grid, x, y + 1);
    }
}