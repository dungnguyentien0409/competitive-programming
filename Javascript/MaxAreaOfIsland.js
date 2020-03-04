/**
 * Problem: https://leetcode.com/problems/max-area-of-island/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} grid
 * @return {number}
 */
var maxAreaOfIsland = function(grid) {
    if (grid.length == 0 || grid[0].length == 0) return 0;
    
    var rows = grid.length;
    var cols = grid[0].length;
    var f_area = 0;
    
    for (var i = 0; i < rows; i++) {
        for (var j = 0; j < cols; j++) {
            var a = area(grid, i, j);
            f_area = Math.max(f_area, a);
        }
    }
    
    return f_area;
};

function area(grid, i, j) {
    if (i < 0 || j < 0 || i > grid.length - 1 || j > grid[0].length - 1 ||
       grid[i][j] == '0') {
        return 0;
    }
    
    grid[i][j] = 0;
    
    return 1 + area(grid, i + 1, j) + area(grid, i - 1, j) + area(grid, i, j - 1) + area(grid, i, j + 1);
}