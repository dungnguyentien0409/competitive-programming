/**
 * Problem: https://leetcode.com/problems/merge-intervals/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} intervals
 * @return {number[][]}
 */
var merge = function(intervals) {
    if (intervals.length == 0) return [];
    
    intervals.sort(function(a, b) { return a[1] - b[1]; });
    
    var res = [intervals[0]];

    for (var i = 1; i < intervals.length; i++) {
        var interval = intervals[i];
        var range = res[res.length - 1];
        
        if (range[1] < interval[0]) {
            // if the range is not overlapping, put to res, set the current consider range to the current interval
            res.push(interval);
        }
        else {
            // if the range is overlapping: merge
            while(res.length > 0 && res[res.length - 1][1] >= interval[0]) {
                range = res.pop();
                range[1] = Math.max(range[1], interval[1]);
            }
            range[0] = Math.min(range[0], interval[0]);
            res.push(range);
        }
    }
    
    return res;
};