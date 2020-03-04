/**
 * Link: https://leetcode.com/problems/generate-parentheses/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @return {string[]}
 */
var generateParenthesis = function(n) {
    var res = [];
    
    // use back track to generate
    backTrack(res, [], n, 0, 0);
    
    return res;
};

function backTrack(res, tmp, n, open, close) {
    if (tmp.length == n * 2) res.push(tmp.slice(0));
    
    if (open < n ) {
        tmp += "("
        backTrack(res, tmp, n, open + 1, close);
        tmp = tmp.substring(0, tmp.length - 1);
    }
    
    if (open > close) {
        tmp += ")";
        backTrack(res, tmp, n, open, close + 1);
        tmp = tmp.substring(0, tmp.length - 1);
    }
}