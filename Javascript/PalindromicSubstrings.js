/**
 * Link: https://leetcode.com/problems/palindromic-substrings/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {number}
 */
var countSubstrings = function(s) {
    if (s.length <= 1) return s.length;
    
    var res = new Set();
    var count = 0;
    for (var len = 1; len <= s.length; len++) {
        for (var i = 0; i <= s.length - len; i++) {
            var tmp = s.substr(i, len);
            
            if (res.has(tmp) || (!res.has(tmp) && isPalindromic(tmp))) {
                res.add(tmp);
                count++;
            }
        }
    }
    
    return count;
};


function isPalindromic(s) {
    if (s.length == 1) return true;
    
    var left = 0;
    var right = s.length - 1;
    
    while(left < right) {
        if (s[left] != s[right]) return false;
        left++;
        right--;
    }
    
    return true;
}