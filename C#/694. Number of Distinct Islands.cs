/*
 * Link: https://leetcode.com/problems/number-of-distinct-islands/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumDistinctIslands(int[][] grid) {
        if (grid.Length == 0 || grid[0].Length == 0) return 0;
        
        var rows = grid.Length;
        var cols = grid[0].Length;
        var isLands = new HashSet<string>();
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    var dir = new StringBuilder();
                    dfs(grid, i, j, dir, "");
                    isLands.Add(dir.ToString());
                }
            }
        }
        
        return isLands.Count;
    }
    
    public void dfs(int[][] grid, int x, int y, StringBuilder sb, string dir) {
        var rows = grid.Length;
        var cols = grid[0].Length;
        
        if (x < 0 || y < 0 || x >= rows || y >= cols || grid[x][y] == 0) return;
        
        grid[x][y] = 0;
        sb.Append(dir);
        
        dfs(grid, x + 1, y, sb, "d");
        dfs(grid, x - 1, y, sb, "u");
        dfs(grid, x, y + 1, sb, "r");
        dfs(grid, x, y - 1, sb, "l");
        sb.Append("b");
    }
}