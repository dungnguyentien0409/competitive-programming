/**
 * Problem: https://leetcode.com/problems/longest-substring-without-repeating-characters/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    var map = Array(128).fill(0);
    var end = 0, begin = 0, d = 0;
    var count = 0;
    
    while(end < s.length) {
        // expend the end to find the unique char until find the duplicated character
        if (map[s.charCodeAt(end++)]++ > 0) count++;
        
        while(count > 0) {
            // expend the start until remove the duplicated character
            if (map[s.charCodeAt(begin++)]-- > 1) count--;
        }
        
        d = Math.max(d, end - begin);
    }
    
    return d;
};