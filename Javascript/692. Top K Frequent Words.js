/**
 * Link: https://leetcode.com/problems/top-k-frequent-words/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string[]} words
 * @param {number} k
 * @return {string[]}
 */
var topKFrequent = function(words, k) {
    var map = {};
    var sorted = [];
    var res = [];
    
    for(var w of words) {
        map[w] = (map[w] || 0) + 1;
    }
    
    for (var key in map) {
        var value = map[key];
        res.push([key, value]);
    }
    
    res.sort(function(a, b) {
        if (a[1] == b[1]) return a[0] < b[0] ? -1 : 1;
        return b[1] - a[1];
    })
    
    return res.slice(0, k).map(item => item[0]);
};