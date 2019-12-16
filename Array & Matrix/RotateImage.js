/**
 * Problem: https://leetcode.com/problems/rotate-image/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: shichaotan
 * @param {number[][]} matrix
 * @return {void} Do not return anything, modify matrix in-place instead.
 */
var rotate = function(matrix) {
    // rotate upside down
    var r1 = 0, r2 = matrix.length - 1;
    while(r1 < r2) {
        var tmp = matrix[r1];
        matrix[r1] = matrix[r2].slice(0);
        matrix[r2] = tmp.slice(0);
        r1++; r2--;
    }
    
    // swap symmetry
    for (var i = 1; i < matrix.length; i++) {
        for (var j = 0; j < i; j++) {
            [matrix[i][j], matrix[j][i]] = [matrix[j][i], matrix[i][j]];
        }
    }
};