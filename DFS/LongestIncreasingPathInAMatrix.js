/**
 * Problem: https://leetcode.com/problems/longest-increasing-path-in-a-matrix/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} matrix
 * @return {number}
 */
var longestIncreasingPath = function(matrix) {
    if (matrix.length == 0 || matrix[0].length == 0) return 0;
    
    var rows = matrix.length;
    var cols = matrix[0].length;
    var cache = Array(rows).fill().map(() => Array(cols).fill(0));
    var max = 0;
    
    for (var i = 0; i < rows; i++) {
        for (var j = 0; j < cols; j++) {
           // use dfs to find the max
           max = Math.max(max, dfs(matrix, i, j, cache));
        }
    }
    
    return max;
};

function dfs(matrix, x, y, cache) {
    if (cache[x][y] > 0) return cache[x][y];
    
    var res = matrix[x][y];
    var directions = [[0, -1], [0, 1], [1, 0], [-1, 0]];
    var currentMax = 1;
    
    for (var dir of directions) {
        var nextX = x + dir[0];
        var nextY = y + dir[1];
        
        
        if (nextX >= 0 && nextX < matrix.length
            && nextY >= 0 && nextY < matrix[0].length
            && matrix[nextX][nextY] > matrix[x][y]) {
            currentMax = Math.max(currentMax, 1 + dfs(matrix, nextX, nextY, cache));
        }
    }
    
    // use cache to cache the value
    cache[x][y] = currentMax;
    return currentMax;
}