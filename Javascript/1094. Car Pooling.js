/**
 * Link: https://leetcode.com/problems/car-pooling/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} trips
 * @param {number} capacity
 * @return {boolean}
 */

var carPooling = function(trips, capacity) {
    var timeCapacities = generateByTime(trips);
    var c = 0;
    
    for (var timeCapacity of timeCapacities) {
        c += timeCapacity[1];
        if (c > capacity) return false;
    }
    
    return true;
};

function generateByTime(trips) {
    var res = [];
    
    for (var trip of trips) {
		// people get in: +capacity, people get out: -capacity
        res.push([trip[1], trip[0]]);
        res.push([trip[2], -trip[0]]);
    }
    
    // sort by time, if people can in and out at the same time. let people get out first
	// so the order like: order by time, if the same time, order asc by capacity
    res.sort(function(a, b) { 
        if (a[0] == b[0]) return a[1] - b[1];
        return a[0] - b[0] 
    });
    
    return res;
}