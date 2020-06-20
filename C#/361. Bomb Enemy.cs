/*
 * Link: https://leetcode.com/problems/bomb-enemy/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxKilledEnemies(char[][] grid) {
        if (grid.Length == 0 || grid[0].Length == 0) return 0;
        
        int rows = grid.Length, cols = grid[0].Length;
        var cal = CreateCalculation(rows, cols);
        
        // from left
        for (var i = 0; i < rows; i++) {
            var countLeft = 0;
            
            for (var j = 0; j < cols; j++) {
                if (grid[i][j] == 'E') {
                    countLeft++;
                }
                else if (grid[i][j] == 'W') {
                    countLeft = 0;
                }
                
                cal[i][j] += countLeft;
            }
        }
        
        // from right 
        for (var i = 0; i < rows; i++) {
            var countRight = 0;
            
            for (var j = cols - 1; j >= 0; j--) {
                cal[i][j] += countRight;
                if (grid[i][j] == 'E') {
                    countRight++;
                }
                else if (grid[i][j] == 'W') {
                    countRight = 0;
                }
            }
        }
        
        // from top
        for (var j = 0; j < cols; j++) {
            var countTop = 0;
            
            for (var i = 0; i < rows; i++) {
                cal[i][j] += countTop;
                if (grid[i][j] == 'E') {
                    countTop++;
                }
                else if (grid[i][j] == 'W') {
                    countTop = 0;
                }
            }
        }
        
        var max = 0;
        // from bottom
        for (var j = cols - 1; j >= 0; j--) {
            var countBtm = 0;
            
            for (var i = rows - 1; i >= 0; i--) {
                cal[i][j] += countBtm;
                if (grid[i][j] == 'E') {
                    countBtm++;
                }
                else if (grid[i][j] == 'W') {
                    countBtm = 0;
                }
                else if (grid[i][j] == '0') {
                    max = Math.Max(max, cal[i][j]);
                }
            }
        }
        
        return max;
    }
    
    public int[][] CreateCalculation(int rows, int cols) {
        var cal = new int[rows][];
        
        for (var i = 0; i < rows; i++) {
            cal[i] = new int[cols];
        }
        
        return cal;
    }
}