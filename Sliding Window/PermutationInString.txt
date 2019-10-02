/**
 * Problem: https://leetcode.com/problems/permutation-in-string/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Using sliding window
 * @param {string} s1
 * @param {string} s2
 * @return {boolean}
 */
var checkInclusion = function(s1, s2) {
    if (s1.length > s2.length) return false;
    
    // create an array to store all character need to find
    var dict = {};
    for (var c of s1) {
        dict[c] = isNaN(dict[c]) ? 1 : ++dict[c];
    }
    
    var end = 0, begin = 0, count = s1.length;
    while(end < s2.length) {
        // expand the end untill all characters found
        // at that time, end point to the next character
        if (dict[s2[end++]]-- > 0) count--;
        
        // count == 0 mean end expand to where all character found
        while(count == 0) {            
            // mean all found char continously
            if (end - begin == s1.length) return true;
            
            // if not mean the string is not correct
            // increase begin to eleminate one char
            // count++ to move on expanding end
            if(dict[s2[begin++]]++ >= 0) count++;
        }
    }
    
    return false;
};