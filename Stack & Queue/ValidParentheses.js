/**
 * Problem: https://leetcode.com/problems/valid-parentheses/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {boolean}
 */
var isValid = function(s) {
    var st = [];
    
    for (var i = 0; i < s.length; i++) {
        if (s[i] == "(" || s[i] == "[" || s[i] == "{") {
            st.push(s[i]);
        }
        else {
            var top = st.pop();
            
            if (s[i] == ")" && top != "(") { 
                return false;
            }
            else if (s[i] == "]" && top != "[") {
                return false;
            }
            else if (s[i] == "}" && top != "{") {
                return false;
            }
        }
    }
    
    if (st.length > 0) return false;
    return true;
};