/**
 * Link: https://leetcode.com/problems/stepping-numbers/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} low
 * @param {number} high
 * @return {number[]}
 */
var countSteppingNumbers = function(low, high) {
    var res = [];
    
    // for each digit, use dfs to generate the 1,2,3,4...-digits number
    for (var digit = 0; digit <= 9; digit++) {
        dfs(low, high, digit, res);
    }
    
    return res.sort(function(a, b) {return a - b;});
};

function dfs(low, high, num, res) {
    if (num >= low && num <= high) res.push(num);
    
    if (num == 0 || num > high) return;
    
    // generate the 2 case digit: ab => a(b+1), a(b-1)
    var lastDigit = num % 10;
    var num1 = num * 10 + (lastDigit - 1);
    var num2 = num * 10 + (lastDigit + 1);
    
    // mean: 10, 20, ..100, the case only can plus one
    if (lastDigit == 0) dfs(low, high, num2, res);
    // mean: 99, 89,.., the case only can substract one
    else if (lastDigit == 9) dfs(low, high, num1, res);
    // other dfs for both cases
    else {
        dfs(low, high, num1, res);
        dfs(low, high, num2, res);
    }
}