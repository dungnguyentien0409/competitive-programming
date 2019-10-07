/**
 * Problem: https://leetcode.com/problems/unique-paths-iii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} grid
 * @return {number}
 */
var uniquePathsIII = function(grid) {
    var start = [];
    var end = [];
    var walks = 2;
    var steps = [];
    res = [];
    
    for (var i = 0; i < grid.length; i++) {
        for (var j = 0; j < grid[0].length; j++) {
            if (grid[i][j] == 1) start = [i, j];
            else if (grid[i][j] == 2) end = [i, j];
            else if (grid[i][j] == 0) walks++;
        }
    }
    
    // find all path and push the value to res
    steps.push(start);
    dfs(grid, start, end, walks, steps);

    return res.length;
};
var res;

function dfs(grid, position, end, walks, steps) {
    // if reach the end point, return
    if (position[0] == end[0] && position[1] == end[1] && steps.length == walks) {
        res.push(steps);
        return
    }
    
    // check if the step go all the empty square
    if (steps.length < walks) {
        var dir = [[0, 1], [1,0], [0, -1], [-1, 0]];
        
        for (var i = 0; i < dir.length; i++) {
            var nextX = position[0] + dir[i][0];
            var nextY = position[1] + dir[i][1];
            var nextMove = [nextX, nextY];
            
            // check if can make the next move
            if (nextX >= 0 && nextX < grid.length 
                && nextY >= 0 && nextY < grid[0].length 
                && grid[nextX][nextY] != -1
                && !steps.some(s => s[0] == nextX && s[1] == nextY)) {
                
                // add the next move
                steps.push(nextMove);
                dfs(grid, nextMove, end, walks, steps);
                // after find or not find the path, remove the nextMove the add another one to move on
                steps.pop()
            }
        }
    }
    return true;
}