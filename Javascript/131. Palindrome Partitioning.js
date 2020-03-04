/**
 * Link: https://leetcode.com/problems/palindrome-partitioning/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {string[][]}
 */
var partition = function(s) {
    var res = [];
    
    backTrack(res, [], s, 0);
    
    return res;
};

function backTrack(res, tmp, s, start) {
    if (start == s.length) {
        res.push(tmp.slice(0));
    }
    for (var i = start; i < s.length; i++) {
        if (isPalindrome(s, start, i)) {
            tmp.push(s.substring(start, i + 1));
            backTrack(res, tmp, s, i + 1);
            tmp.pop();
        }
    }
}

function isPalindrome(s, start, end) {
    while (start < end) {
        if (s[start++] != s[end--]) return false;
    }
    return true;
}