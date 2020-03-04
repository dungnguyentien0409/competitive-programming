/*
 * Link: https://leetcode.com/problems/set-matrix-zeroes/
 * Author: Dung Nguyen Tien (Chris)
 * Idea: mzchen
*/

public class Solution {
    public void SetZeroes(int[][] matrix) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return;
        // save to the first of row or col
        // only run from row 1 and col 1 - to keep the condition
        // afterwards, run for row 0, col 0
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        var row0 = false;
        var col0 = false;
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (matrix[i][j] == 0) {
                    if (i == 0) row0 = true;
                    if (j == 0) col0 = true;
                    
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        
        for (var i = 1; i < rows; i++) {
            for (var j = 1; j < cols; j++) {
                if (matrix[i][0] == 0 || matrix[0][j] == 0) {
                    matrix[i][j] = 0;
                }
            }
        }
        
        if (row0) {
            for (var j = 0; j < cols; j++) matrix[0][j] = 0;
        }
        
        if (col0) {
            for (var i = 0; i < rows; i++) matrix[i][0] = 0;
        }
    }
}