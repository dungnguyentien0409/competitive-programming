/**
 * Link: https://leetcode.com/problems/unique-paths/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} m
 * @param {number} n
 * @return {number}
 */
var uniquePaths = function(m, n) {
    if (m == 0 && n == 0) return 0;
    
    var matrix = Array(m).fill().map(() => Array(n).fill(0));
    matrix[0][0] = 1;
    
    // the ways to position matrix[i][j] equals to the total way to the previous left position or previous upper position, calculate it until we reach the last
    for (var i = 0; i < m; i++) {
        for (var j = 0; j < n; j++) {
            if (i != 0 || j != 0){
                var previousUp = i - 1 >= 0 && j >= 0 ? matrix[i - 1][j] : 0;
                var previousLeft = i >= 0 && j - 1 >= 0 ? matrix[i][j - 1] : 0;

                matrix[i][j] = previousUp + previousLeft;
            }
        }
    }
    return matrix[m - 1][n - 1];
};