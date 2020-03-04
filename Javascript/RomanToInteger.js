/**
 * Problem: https://leetcode.com/problems/roman-to-integer/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {number}
 */
var romanToInt = function(s) {
    var res = 0;
    
    for (var i = s.length - 1; i >= 0; i--) {
        var c = s[i];
        
        switch(c) {
            case "I": 
                res = res < 5 ? res + 1 : res - 1;
                break;
            case "V": 
                res += 5;
                break;
            case "X": 
                res = res < 50 ? res + 10 : res - 10;
                break;
            case "L": 
                res += 50;
                break;
            case "C": 
                res = res < 500 ? res + 100 : res - 100;
                break;
            case "D": 
                res += 500;
                break;
            case "M": 
                res += 1000;
                break;
        }
    }
    
    return res;
};