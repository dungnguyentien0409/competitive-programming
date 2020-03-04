/**
 * Link: https://leetcode.com/problems/longest-arithmetic-subsequence-of-given-difference/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} arr
 * @param {number} difference
 * @return {number}
 */
var longestSubsequence = function(arr, difference) {
    var map = {};
    var longest = 0;
    for (var i = 0; i < arr.length; i++) {
        // map[arr[i]] is the longest until the current i with value arr[i], so the previous value should be arr[i] - different
        map[arr[i]] = map[arr[i] - difference] == undefined ? 1 : map[arr[i] - difference] + 1;
        longest = Math.max(longest, map[arr[i]]);
    }
    
    return longest;
};