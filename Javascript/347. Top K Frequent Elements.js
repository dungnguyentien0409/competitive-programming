/**
 * Link: https://leetcode.com/problems/top-k-frequent-elements/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @param {number} k
 * @return {number[]}
 */
var topKFrequent = function(nums, k) {
    var map = {};
    
    for (var n of nums) {
        map[n] = (map[n] || 0) + 1;
    }
    
    var res = [];
    for (var i in map) {
        res.push([i, map[i]]);
    }
    
    res.sort(function(a, b) {
        if (a[1] == b[1]) return a[0] - b[0];
        return b[1] - a[1];
    })

    return res.slice(0, k).map(v => v[0]);
};