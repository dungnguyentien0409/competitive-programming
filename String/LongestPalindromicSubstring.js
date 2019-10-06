/**
 * Problem: https://leetcode.com/problems/longest-palindromic-substring/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {string}
 */
var longestPalindrome = function(s) {
    if (s.length < 2) {
        return s;
    }
    
    // for each i, expand to left and to right
    var max = "";
    for (var i = 0; i < s.length; i++) {
        var left = i - 1;
        var right = i + 1;
        var currentMax = "";
        
        if (left >= -1 && right < s.length) {
            currentMax = s[i];
            // expand to right first to find the same elements in center
            while(s[i] == s[right]) {
                currentMax = currentMax + s[right];
                right++;
            }
            
            // expand to left and right to find the palindromic elements
            while(s[left] == s[right] && left >= 0 && right < s.length) {
                currentMax = s[left] + currentMax + s[right];
                left--;
                right++;
            }
            
            max = findMax(max, currentMax);
        } 
    }
    return max;
};

function findMax(a, b) {
    return a.length >= b.length ? a : b;
}