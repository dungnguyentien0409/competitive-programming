/**
 * Problem: https://leetcode.com/problems/spiral-matrix-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @return {number[][]}
 */
var generateMatrix = function(n) {
    var res = Array(n).fill(0).map(a => Array(n).fill(0));
    
    var r1 = 0, r2 = n - 1;
    var c1 = 0, c2 = n - 1;
    var i = 0;
    
    while(r1 <= r2 && c1 <= c2) {
        // go from the top left to the top right
        for (var c = c1; c <= c2; c++) res[r1][c] = ++i;
        // go from the top right to the bottom right
        for (var r = r1 + 1; r <= r2; r++) res[r][c2] = ++i;
        // check for the case the matrix have only one col or one row
        if (r1 < r2 && c1 < c2) {
            // go from the bottom right to bottom left
            for (var c = c2 - 1; c > c1; c--) res[r2][c] = ++i;
            // go from the bottom left to the top left
            for (var r = r2; r > r1; r--) res[r][c1] = ++i;
        }
        // scale the matrix
        r1++;
        c1++;
        r2--;
        c2--;
    }
    
    return res;
};