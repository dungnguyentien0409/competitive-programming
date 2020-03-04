/**
 * Problem: https://leetcode.com/problems/basic-calculator/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {number}
 */
var calculate = function(s) {
    // dont add the number to res until we find the nex +/-
    var st = [];
    var sign = 1;
    var res = 0;
    var number = 0;
    
    for (var c of s) {
        if (isDigit(c)) {
            number = number * 10 + (c - '0');
        }
        else if (c == '+' || c == '-') {
            res += sign * number;
            number = 0;
            c == '+' ? sign = 1 : sign = -1;
        }
        else if (c == '(') {
            st.push(res);
            st.push(sign);
            // go to element inside parentheses
            sign = 1;
            res = 0;
        }
        else if (c == ')') {
            res += (sign * number);
            number = 0;
            //get the sign of value inside parentheses
            res *= st.pop();
            //add the value inside parentheses to previous
            res += st.pop();
        }
    }
    
    if (number != 0) res += (sign * number);
    return res;
};

function isDigit(c) {
    return c >= '0' && c <= '9'
}