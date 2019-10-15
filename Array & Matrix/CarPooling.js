/**
 * Problem: https://leetcode.com/problems/car-pooling/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} trips
 * @param {number} capacity
 * @return {boolean}
 */
var carPooling = function(trips, capacity) {
    // we have at most 1000 stop
    var stops = Array(1001).fill(0);
    
    // calculate the increase or decrease of people for each stop
    for (var trip of trips) {
        stops[trip[1]] += trip[0];
        stops[trip[2]] -= trip[0];
    }
    
    // at each stop count the total
    var total = 0;
    for (var i = 0; i <= 1000; i++) {
        total += stops[i];
        if (total > capacity) return false;
    }
    
    return true;
};