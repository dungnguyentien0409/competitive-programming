/**
 * Problem: https://leetcode.com/problems/custom-sort-string/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} S
 * @param {string} T
 * @return {string}
 */
var customSortString = function(S, T) {
    return T.split('')
            .sort(function(a, b) { 
                var ia = S.indexOf(a) >= 0 ? S.indexOf(a) : Number.MAX_SAFE_INTEGER;
                var ib = S.indexOf(b) >= 0 ? S.indexOf(b) : Number.MAX_SAFE_INTEGER
                return ia - ib;
                //return (S.indexOf(a) | 0) - (S.indexOf(b) | 0);
            })
            .join('');
};