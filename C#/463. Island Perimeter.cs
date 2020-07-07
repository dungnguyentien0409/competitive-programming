/*
 * Link: https://leetcode.com/problems/island-perimeter/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int IslandPerimeter(int[][] grid) {
        if (grid.Length == 0 || grid[0].Length == 0) return 0;
        
        int rows = grid.Length, cols = grid[0].Length;
        var perimeter = 0;
        var directions = new int[4][] {
            new int[2] { 1, 0 }, new int[2] { -1, 0 },
            new int[2] { 0, 1 }, new int[2] { 0, -1 }
        };
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    var thisPerimeter = 4;
                    
                    foreach(var d in directions) {
                        var nextX = i + d[0];
                        var nextY = j + d[1];
                        
                        if (nextX >= 0 && nextY >= 0 && nextX < rows && nextY < cols
                           && grid[nextX][nextY] == 1) thisPerimeter--;
                    }
                    
                    perimeter += thisPerimeter;
                }    
            }
        }
        
        return perimeter;
    }
}