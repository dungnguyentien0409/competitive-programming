/**
 * Problem: https://leetcode.com/problems/shortest-palindrome/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: myfavcat123
 * @param {string} s
 * @return {string}
 */
var shortestPalindrome = function(s) {
    var tmp = s + '#' + s.slice(0).split('').reverse().join('');
    console.log(tmp);
    
    // find the longest palindrome start from 0 then reverse the rest
    var computedPattern = buildComputedPattern(tmp);
    var res = s.slice(computedPattern[computedPattern.length - 1]).split('').reverse().join('') + s;
    return res;
};

function buildComputedPattern(s) {
    var computedPattern = Array(s.length).fill(0);
    var prefix = 0;
    var suffix = 1;
    
    while(suffix < s.length) {
        if (s[prefix] == s[suffix]) {
            computedPattern[suffix] = prefix + 1;
            suffix++;
            prefix++;
        }
        else if (prefix == 0) {
            computedPattern[suffix++] = 0;
        }
        else {
            prefix = computedPattern[prefix - 1];
        }
    }
    
    return computedPattern;
}