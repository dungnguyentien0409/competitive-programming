/**
 * Problem: https://leetcode.com/problems/implement-strstr/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} haystack
 * @param {string} needle
 * @return {number}
 */

// using KMP algorithm
var strStr = function(haystack, needle) {
    if (haystack.length < needle.length) return -1;
    if (needle.length == 0) return 0;
    
    
    var hIndex = 0, nIndex = 0;
    var computedPattern = buildComputedPattern(needle);
    
    while(hIndex < haystack.length) {
        if (haystack[hIndex] == needle[nIndex]) {
            if (nIndex == needle.length - 1) return hIndex - nIndex;
            
            ++hIndex;
            ++nIndex;
        }
        else if (nIndex == 0) {
            hIndex++;
        }
        else {
            nIndex = computedPattern[nIndex - 1];
        }
    }
    
    return -1;
};


function buildComputedPattern(needle) {
    var computedPattern = Array(needle.length).fill(0);
    var prefix = 0;
    var suffix = 1;
    
    while(suffix < needle.length) {
        if (needle[prefix] == needle[suffix]) {
            computedPattern[suffix] = prefix + 1;
            prefix++;
            suffix++;
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
