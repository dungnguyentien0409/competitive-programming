/**
 * Link: https://leetcode.com/problems/path-with-maximum-gold/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} grid
 * @return {number}
 */
var getMaximumGold = function(grid) {
    maxGold = Number.MIN_SAFE_INTEGER;
    
    // start from any cell having some gold
    for (var i = 0; i < grid.length; i++) {
        for (var j = 0; j < grid[0].length; j++) {
            if (grid[i][j] != 0) {
                var start = [i, j];
                dfs(grid, start, 0, [start]);
            }
        }
    }
    
    return maxGold;
};

var maxGold;
// use dfs to collect coin
function dfs(grid, pos, gold, steps) {
    gold += grid[pos[0]][pos[1]];
    maxGold = Math.max(maxGold, gold);
    
    var dir = [[1, 0], [0, 1], [-1, 0], [0, -1]];
    
    for (var i = 0; i < dir.length; i++) {
        var nextX = pos[0] + dir[i][0];
        var nextY = pos[1] + dir[i][1];
        var nextMove = [nextX, nextY];

        if (nextX >= 0 && nextX < grid.length
            && nextY >= 0 && nextY < grid[0].length
            && !steps.some(s => s[0] == nextX && s[1] == nextY)
            && grid[nextX][nextY] != 0){
            
            steps.push(nextMove);
            dfs(grid, nextMove, gold, steps);
            steps.pop();
        }
    }
}