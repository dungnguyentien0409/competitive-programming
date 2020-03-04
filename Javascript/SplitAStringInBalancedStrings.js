/**
 * Link: https://leetcode.com/problems/split-a-string-in-balanced-strings/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {number}
 */
var balancedStringSplit = function(s) {
    var count = 0;
    var isBalanced = 0;
    
    for (var i = 0; i < s.length; i++) {
        // if L +1, R-1. while we get 0 mean L == R
        isBalanced += (s[i] == 'L' ? 1 : -1);
        if (isBalanced == 0) ++count;
    }
    
    return count;
};