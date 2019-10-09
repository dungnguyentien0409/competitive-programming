/**
 * Problem: https://leetcode.com/problems/friend-circles/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} M
 * @return {number}
 */
var findCircleNum = function(M) {
    var n = M.length;
    var count = 0;
    
    var visited = Array(n).fill(false);
    for (var i = 0; i < n; i++) {
        // if i has no friend, increase count and find
        if (!visited[i]) {
            count++;
            // find all direct and indirect friends of i
            dfs(M, visited, i, n);
        }
    }
    
    return count;
};

function dfs(M, visited, pos, n) {
    visited[pos] = true;
    for (var i = 0; i < n; i++) {
        if (M[pos][i] == 1 && visited[i] == false) {
            dfs(M, visited, i, n);
        }
    }
}