/**
 * Problem: https://leetcode.com/problems/minimum-window-substring/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @param {string} t
 * @return {string}
 */
var minWindow = function(s, t) {
    // using sliding window
    // map to store all character
    var map = Array(128).fill(0);
    
    // count the character in t
    for(var w of t) {
        map[w.charCodeAt(0)]++;
    }
    
    var count = t.length;
    var begin = 0, end = 0, d = Number.MAX_SAFE_INTEGER, head = 0;
    
    while(end < s.length) {
        // increse the end untill all the characters in t found
        if (map[s[end++].charCodeAt(0)]-- > 0) count--;
        
        // while all the character in t has been found, increase begin to find the minimum
        while(count == 0) {
            if (end - begin < d) d = end - (head = begin);
            
            // if one of the character lost, increase count to increase the end
            if (map[s[begin++].charCodeAt(0)]++ == 0) count++;
        }
    }
    
    return d < Number.MAX_SAFE_INTEGER ? s.substr(head, d) : "";
};