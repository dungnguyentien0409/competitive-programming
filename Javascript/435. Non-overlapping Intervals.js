/**
 * Link: https://leetcode.com/problems/non-overlapping-intervals/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} intervals
 * @return {number}
 */
var eraseOverlapIntervals = function(intervals) {
    if (intervals.length == 0) return 0;
    
    intervals.sort(function(a, b) {return a[1] - b[1]; });
    
    var remove = 0;
    var range = intervals[0];
    for (var i = 1; i < intervals.length; i++) {
        var interval = intervals[i];
        
        if (range[1] > interval[0]) {
            // if overlapping then remove
            remove++;
        }
        else {
            // if not overlapping, update the currently considered range
            range = interval.slice(0);
        }
    }
    
    return remove;
};