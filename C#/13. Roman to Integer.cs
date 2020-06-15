/*
 * Link: https://leetcode.com/problems/roman-to-integer/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int RomanToInt(string s) {
        var res = 0;
    
    for (var i = s.Length - 1; i >= 0; i--) {
        var c = s[i].ToString();
        
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
    }
}