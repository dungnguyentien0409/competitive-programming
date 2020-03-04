/**
 * Link: https://leetcode.com/problems/k-closest-points-to-origin/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} points
 * @param {number} K
 * @return {number[][]}
 */
var kClosest = function(points, K) {
    if (K == 0) return [[]];
    var sorted = [];
    
    for(var p of points) {
        var distance = getDistanceSquare(p);
        var item = [distance, p];
        var index = binarySearch(sorted, distance);
        sorted.splice(index, 0, item);
    }
    
    var result = [];
    for (var i = 0; i < K; i++) result.push(sorted[i][1]);
    
    return result;
};

function getDistanceSquare(point) {
    //console.log(point);
    return point[0] * point[0] + point[1] * point[1];
}

function binarySearch(sorted, distance) {
    if (sorted.length == 0) return 0;
    
    var left = 0;
    var right = sorted.length - 1;
    
    while(left < right) {
        var mid = Math.floor((left + right) / 2);

        if (sorted[mid][0] < distance) left = mid + 1;
        else right = mid;
    }
    
    if (sorted[left][0] < distance) return left + 1;
    return left;
}

