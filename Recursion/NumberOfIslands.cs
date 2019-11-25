/*
 * Problem: https://leetcode.com/problems/number-of-islands/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid.Length == 0 || grid[0].Length == 0) return 0;
        
        var rows = grid.Length;
        var cols = grid[0].Length;
        var isLands = 0;
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (grid[i][j] == '1') {
                    isLands++;
                    Mark(grid, i, j);
                }        
            }
        }
        
        return isLands;
    }
    
    public void Mark(char[][] grid, int x, int y) {
        if (x < 0 || x >= grid.Length ||
            y < 0 || y >= grid[0].Length || grid[x][y] == '0')
            return;
        
        grid[x][y] = '0';
        Mark(grid, x - 1, y);
        Mark(grid, x + 1, y);
        Mark(grid, x, y - 1);
        Mark(grid, x, y + 1);
    }
}