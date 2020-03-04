/**
 * Problem: https://leetcode.com/problems/unique-paths-ii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} obstacleGrid
 * @return {number}
 */
var uniquePathsWithObstacles = function(obstacleGrid) {
    if (obstacleGrid.length == 0 || obstacleGrid[0].length == 0 || obstacleGrid[0][0] == 1) return 0;
    
    var rows = obstacleGrid.length;
    var cols = obstacleGrid[0].length;
    // dp[i][j] is the total unique paths to come to [i, j]
    var dp = Array(rows).fill(0).map(() => Array(cols).fill(0));
    dp[0][0] = 1;
    
    for (var i = 0; i < rows; i++) {
        for (var j = 0; j < cols; j++) {
            // the current unique path of [i,j] is the total of the unique path of left + the unique path of up. if there is an obstacle then the unique path from up or left equal to 0
            if (i != 0 && j != 0) {
                var previousLeft = obstacleGrid[i][j] == 1 ? 0 : dp[i][j - 1];
                var previousUp = obstacleGrid[i][j] == 1 ? 0 : dp[i - 1][j];
                dp[i][j] = (previousLeft || 0) + (previousUp || 0);
            }
            else if (i == 0 && j != 0) {
                var previousLeft = obstacleGrid[i][j] == 1 ? 0 : dp[i][j - 1];
                dp[i][j] += previousLeft;
            }
            else if (j == 0 && i != 0) {
                var previousUp = obstacleGrid[i][j] == 1 ? 0 : dp[i - 1][j];
                dp[i][j] += previousUp;
            }
        }
    }
    console.log(dp);
    return dp[rows - 1][cols - 1];
};