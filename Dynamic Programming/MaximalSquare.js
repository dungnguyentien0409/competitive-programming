/**
 * Problem: https://leetcode.com/problems/maximal-square/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: earlme
 * @param {character[][]} matrix
 * @return {number}
 */
var maximalSquare = function(matrix) {
    if (matrix.length == 0 || matrix[0].length == 0) return 0;
    
    var res = 0;
    var rows = matrix.length;
    var cols = matrix[0].length;
    // dp[i, j] represent largest square having bottom right corner at i, j
    var dp = Array(rows + 1).fill().map(() => Array(cols + 1).fill(0));
    
    for (var i = 1; i <= rows; i++) {
        for (var j = 1; j <= cols; j++) {
            if (matrix[i - 1][j - 1] == '1') {
                // dp[i][j]=> extend one right, one down, so check for 3 dimension
                // if one miss, cant form the square
                dp[i][j] = Math.min(dp[i - 1][j], dp[i][j - 1], dp[i - 1][j - 1]) + 1;
                res = Math.max(res, dp[i][j]);
            }
        }
    }

    return res * res;
};
};