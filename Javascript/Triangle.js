/**
 * Link: https://leetcode.com/problems/triangle/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} triangle
 * @return {number}
 */
var minimumTotal = function(triangle) {
    var rows = triangle.length;
    var dp = Array(rows).fill(0).map(() => Array(rows).fill(0));
    
    // trace from the bottom
    for (var i = 0; i < rows; i++) {
        dp[rows - 1][i] = triangle[rows - 1][i];
    }
    
    // go up until reach the top, and update the current min sum
    for (var r = rows - 2; r >= 0; r--) {
        for (var c = 0; c < triangle[r].length; c++) {
            dp[r][c] = triangle[r][c] + Math.min(dp[r + 1][c], dp[r + 1][c + 1]);
        }
    }
    
    return dp[0][0];
};
