/**
 * Problem: https://leetcode.com/problems/word-break/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @param {string[]} wordDict
 * @return {boolean}
 */
var wordBreak = function(s, wordDict) {
    // f1: means from s[0] to s[1 - 1] is the segment of wordDict
    // f2: means from s[0] to s[2 - 1] is the segment of wordDict
    // so on
    var f = Array(s.length + 1).fill(false);
    f[0] = true;
    
    // increase the length need to be considered
    // first from 1 element, until the full length
    for (var len = 1; len <= s.length; len++) {
        for (var w of wordDict) {
            // if the considered length is enough with the w in wordDict
            // and all the left words is valid
            // and the right word added is in wordDict
            if (len >= w.length && f[len - w.length] && s.substr(len - w.length, w.length) == w) {
                f[len] = true;
            }
        }
    }
    console.log(f);
    // check until the last element
    return f[s.length];
};