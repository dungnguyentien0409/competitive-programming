/**
 * Problem: https://leetcode.com/problems/longest-valid-parentheses/solution/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {number}
 */
var longestValidParentheses = function(s) {
    // the top of stack store the position right before the begin of longest valid parenthese. so that we substract the end with the top of the stack to get the length
    var st = [-1];
    var max_length = 0;
    
    for (var i = 0; i < s.length; i++) {
        if (s[i] == "(") {
            // push all index of "(" into stack
            st.push(i);
        }
        else {
            // find the ")" get the "(" out of the stack. then the top of stack point to before the begin of longest valid parenthese
            st.pop();
            console.log(st);
            // if the stack empty mean we pop the -1 out, so need to another point right before the begin of longest valid parenthese, push i and pop until the element after i is "("
            if (st.length == 0) st.push(i);
            //substract the end and the top of the stack
            else max_length = Math.max(max_length, i - st[st.length - 1]);
        }
    }
    return max_length;
};