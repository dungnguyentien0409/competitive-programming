/**
 * Problem: https://leetcode.com/problems/integer-to-roman/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: fabrizio3
 * @param {number} num
 * @return {string}
 */
var intToRoman = function(num) {
    var I = ["", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"];
    var X = ["", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"];
    var C = ["", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"];
    var M = ["", "M", "MM", "MMM"];
    
    console.log(I[Math.floor(num % 10)]);
    var res = (M[Math.floor(num / 1000)]
              + C[Math.floor(num % 1000 / 100)]
              + X[Math.floor(num % 100 / 10)]
              + I[Math.floor(num % 10)])
    
    return res;
};