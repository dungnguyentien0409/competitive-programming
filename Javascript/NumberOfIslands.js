/**
 * Link: https://leetcode.com/problems/number-of-islands/
 * Author: Dung Nguyen Tien (Chris)
 * @param {character[][]} grid
 * @return {number}
 */
var numIslands = function(grid) {
    if (grid.length == 0 || grid[0].length == 0) return 0;
    
    var rows = grid.length;
    var cols = grid[0].length;
    var res = 0;
    
    for (var i = 0; i < rows; i++) {
        for (var j = 0; j < cols; j++) {
            res += mark(grid, i, j);
        }
    }
    
    return res;
};

function mark(grid, i, j) {
    if (i < 0 || i > grid.length - 1 || j < 0 || j > grid[0].length - 1 || grid[i][j] == 0) {
        return 0;
    }
    
    grid[i][j] = 0;
    mark(grid, i - 1, j);
    mark(grid, i + 1, j);
    mark(grid, i, j + 1);
    mark(grid, i, j - 1);
    
    return 1;
}