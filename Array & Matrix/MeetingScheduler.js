/**
 * Problem: https://leetcode.com/problems/meeting-scheduler/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} slots1
 * @param {number[][]} slots2
 * @param {number} duration
 * @return {number[]}
 */
var minAvailableDuration = function(slots1, slots2, duration) {
    slots1.sort(function(a, b) {return a[0] - b[0]});
    slots2.sort(function(a, b) {return a[0] - b[0]});
    
    var i1 = 0, i2 = 0;
    while(i1 < slots1.length && i2 < slots2.length) {
        // the start that 2 people can join is the maximum of two
        // the end that 2 people can join is the minimum of two
        var start = Math.max(slots1[i1][0], slots2[i2][0]);
        var end  = Math.min(slots1[i1][1], slots2[i2][1]);
        
        if (end - start >= duration) 
            return [start, start + duration];
        // if that person cant join that time, find the next time
        else if (slots1[i1][0] <= slots2[i2][0] && slots1[i1][1] < slots2[i2][1]) 
            i1++;
        else 
            i2++;
    }
    
    return [];
};