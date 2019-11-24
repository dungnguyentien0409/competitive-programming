/*
 * Problem: https://leetcode.com/problems/count-servers-that-communicate/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CountServers(int[][] grid) {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var row = new int[rows];
        var col = new int[cols];
        var count = 0;
        
        Array.Fill(row, 0);
        Array.Fill(col, 0);
        // count server for each col and row
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    ++row[i];
                    ++col[j];
                }
            }
        }
        Print(row);
        Print(col);
        // check if the current col and row having more than one server: count
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (grid[i][j] == 1 && (row[i] > 1 || col[j] > 1)) {
                    ++count;
                }
            }
        }
        
        return count;
    }
    
    public void Print(int[] a) {
        for (var i = 0; i < a.Length; i++) {
            Console.Write(a[i] + " ");
        }
    }
}