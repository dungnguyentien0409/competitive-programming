/**
 * @param {number[][]} workers
 * @param {number[][]} bikes
 * @return {number}
 */
var assignBikes = function(workers, bikes) {
    min = Number.MAX_SAFE_INTEGER;
    var visited = Array(bikes.length).fill(false);
    
    dfs(workers, bikes, 0, 0, visited);
    
    return min;
};
var min

function dfs(workers, bikes, totalDistance, i, visited) {
    if (i >= workers.length) {
        min = Math.min(min, totalDistance);
        return;
    }
    
    if (totalDistance > min) {
        return;
    }
    
    for(var j = 0; j < bikes.length; j++) {
        if (visited[j]) continue;
        
        visited[j] = true;
        
        dfs(workers, bikes, totalDistance + distance(workers[i], bikes[j]), i + 1, visited);
        
        visited[j] = false;
    }
}

function distance(a, b) {
    return Math.abs(a[0] - b[0]) + Math.abs(a[1] - b[1]);
}