/*
 * Link: https://leetcode.com/problems/rotate-image/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: shichaotan
*/

public class Solution {
    public void Rotate(int[][] matrix) {
        // rotate image upside down
        int up = 0;
        int down = matrix.Length - 1;
        var len = matrix[0].Length;
        var tmp = new int[len];
        
        while(up < down) {
            Array.Copy(matrix[up], tmp, len);
            Array.Copy(matrix[down], matrix[up], len);
            Array.Copy(tmp, matrix[down], len);
            
            up++;
            down--;
        }
        
        // swap matrix symmetry
        for (var i = 1; i < matrix.Length; i++) {
            for (var j = 0; j < i; j ++) {
                var val = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = val;
            }
        }
    }
}