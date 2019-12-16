/**
 * Problem: https://leetcode.com/problems/01-matrix/submissions/
 * Author: Dung Nguyen Tien (Chirs)
 * @param {number[][]} matrix
 * @return {number[][]}
 */
var updateMatrix = function(matrix) {
    var rows = matrix.length;
    var cols = matrix[0].length;
    
    for (var i = 0; i < rows; i++) {
        for (var j = 0; j < cols; j++) {
            if (matrix[i][j] == 1) {
                currentMin = Number.MAX_SAFE_INTEGER;
                var closest = traceDistance(matrix, i, j, 0);
                //if (closest < Number.MAX_SAFE_INTEGER)
                    matrix[i][j] = closest;
            }
        }
    }
    
    return matrix;
};

var currentMin = Number.MAX_SAFE_INTEGER;

function traceDistance(matrix, x, y, count) {
    if (x < 0 || y < 0 || x >= matrix.length || y >= matrix[0].length) 
        
    
    // there are four way, if one way find the min
    // or if the matrix[x][y] already calculated
    // return the min of current step matrix[x][y]
    if (matrix[x][y] != 1 || count > currentMin) {
        return matrix[x][y];
    }
    

    var tmp = matrix[x][y]; 
    // mark that point visited
    matrix[x][y] = Number.MAX_SAFE_INTEGER;
    // from A to B is count, from B to 0, so count need to + 1
    count = Math.min(traceDistance(matrix, x - 1, y, count + 1),
                     traceDistance(matrix, x + 1, y, count + 1),
                     traceDistance(matrix, x, y - 1, count + 1),
                     traceDistance(matrix, x, y + 1, count + 1)) + 1;
    // return the value for that point
    matrix[x][y] = tmp;
    currentMin = count;
    return count;
}