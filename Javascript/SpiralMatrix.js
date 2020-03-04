/**
 * Problem: https://leetcode.com/problems/spiral-matrix/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} matrix
 * @return {number[]}
 */
var spiralOrder = function(matrix) {
    var ans = [];
    
    if (matrix.length == 0) return ans;
    
    var r1 = 0, r2 = matrix.length - 1;
    var c1 = 0, c2 = matrix[0].length - 1;
    
    while(r1 <= r2 && c1 <= c2) {
        // go from the top left to the top right
        for (var c = c1; c <= c2; c++) ans.push(matrix[r1][c]);
        // go from the top right to the bottom right
        for (var r = r1 + 1; r <= r2; r++) ans.push(matrix[r][c2]);
        // check for the case the matrix have only one col or one row
        if (r1 < r2 && c1 < c2) {
            // go from the bottom right to bottom left
            for (var c = c2 - 1; c > c1; c--) ans.push(matrix[r2][c]);
            // go from the bottom left to the top left
            for (var r = r2; r > r1; r--) ans.push(matrix[r][c1]);
        }
        // scale the matrix
        r1++; 
        c1++;
        r2--;
        c2--;
    }
    
    return ans;
};