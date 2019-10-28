/**
 * Problem: https://leetcode.com/problems/basic-calculator-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {number}
 */
var calculate = function(s) {
    if (s.length == 0) return 0;
    
    // foreach number if it is a sum or substract, push that number with its sign, if multiple or divide: calculate its value and push to stack
    var st = [];
    var number = 0;
    var sign = "+";
    
    for (var i = 0; i < s.length; i++) {
        var c = s[i];
        
        if (isDigit(c)) {
            number = number * 10 + (c - '0');
        }
        
        if (isOperator(c) || i == s.length - 1) {
            if (sign == "+") st.push(number);
            else if (sign == "-") st.push(-number);
            else if (sign == "*") st.push(st.pop() * number);
            else {
                var prevNumber = st.pop();
                prevNumber > 0 ? st.push(Math.floor(prevNumber / number)) 
                               : st.push(Math.ceil(prevNumber / number));
            };
            
            sign = c;
            number = 0;
        }
    }
    
    // sum all the value in stack
    var res = 0;
    for (var n of st) res += n;
    
    return res;
};
    
function isDigit(c) {
    return  c >= '0' && c <= '9';
}

function isOperator(c) {
    return c == "+" || c == "-" || c == "*" || c == "/";
}