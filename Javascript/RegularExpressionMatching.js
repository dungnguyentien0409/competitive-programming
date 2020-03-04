/**
 * Problem: https://leetcode.com/problems/regular-expression-matching/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Idea: Tushar Roy
 * Reference: https://www.youtube.com/watch?v=l3hda49XcDE
 * @param {string} s
 * @param {string} p
 * @return {boolean}
 */
var isMatch = function(s, p) {
    var T = Array(s.length + 1).fill().map(() => Array(p.length + 1).fill(false));
    
    T[0][0] = true;
    //Deals with patterns like a* or a*b* or a*b*c*
    for (var i = 2; i <= p.length; i++) {
        if (p[i - 1] == "*") T[0][i] = T[0][i - 2];
    }
    
    for (var lens = 1; lens <= s.length; lens++) {
        for (var lenp = 1; lenp <= p.length; lenp++) {
            if (s[lens - 1] == p[lenp - 1] || p[lenp - 1] == ".") {
                T[lens][lenp] = T[lens - 1][lenp - 1];
            }
            else if (p[lenp - 1] == "*") {
                // 0 occurance
                T[lens][lenp] = T[lens][lenp - 2];
                if (s[lens - 1] == p[lenp - 2] || p[lenp - 2] == ".")
                    T[lens][lenp] = T[lens][lenp] || T[lens - 1][lenp];
            }
        }
    }
    console.log(T);
    return T[s.length][p.length];
};