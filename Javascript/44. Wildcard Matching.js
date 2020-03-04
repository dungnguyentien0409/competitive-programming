/**
 * Link: https://leetcode.com/problems/wildcard-matching/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Idea by Tushar Roy
 * @param {string} s
 * @param {string} p
 * @return {boolean}
 */
var isMatch = function(s, p) {
    p = p.replace(/\*+/g, '*');
    
    // T[i][j] indicate if s[0..i-1] match p[0...i-1]
    var T = Array(s.length + 1).fill().map(() => Array(p.length + 1).fill(false));
    
    T[0][0] = true;
    if (p[0] == "*") T[0][1] = true;
    
    for (var lens = 1; lens <= s.length; lens++) {
        for (var lenp = 1; lenp <= p.length; lenp++) {
            if (p[lenp - 1] == "?" || p[lenp - 1] == s[lens - 1]) {
                T[lens][lenp] = T[lens - 1][lenp - 1];
            }
            else if (p[lenp - 1] == "*") {
                // look to the left [i][j - 1] in case of * indicate empty string
                // look to the top [i - 1][j] in case of * indicate a character
                T[lens][lenp] = T[lens - 1][lenp] || T[lens][lenp - 1];
            }
        }
    }
    
    return T[s.length][p.length];
};