/**
 * Link: https://leetcode.com/problems/longest-palindrome/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {number}
 */
var longestPalindrome = function(s) {
    var c = Array(128).fill(0);
    
    for (var i = 0; i < s.length; i++) {
        ++c[s.charCodeAt(i)];
    }
    
    var odd = 0;
    var even = 0;
    var hasOddElement = 0;

    for (var i = 0; i < 128; i++) {
        // for each even element, count the length
        if (c[i] % 2 == 0) even += c[i];
        else {
            // for each odd element, count the length - 1 element
            odd += (c[i] - 1);
            hasOddElement = 1;
        }
    }
    
    // if has odd element, there is only one odd element is accepted, so plus one
    return even + odd + hasOddElement;
};