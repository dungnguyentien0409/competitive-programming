/**
 * Link: https://leetcode.com/problems/longest-consecutive-sequence/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number}
 */
var longestConsecutive = function(nums) { 
    var longest = 0;
    var map = {};
    
    // each boundaries n: have the value of the longest string inside
    for (var n of nums) {
        if (map[n] == undefined) {
            var left = map[n - 1] || 0; // length of boundary n - 1
            var right = map[n + 1] || 0; // length of boundary n + 1
            var length = left + right + 1;
            
            map[n] = length;
            longest = Math.max(longest, length);
            
            // update the left boundary of left and right boundary of right
            map[n - left] = length;
            map[n + right] = length;
        }
    }
    
    return longest;
};