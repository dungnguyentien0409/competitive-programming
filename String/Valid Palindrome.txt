/**
 * Problems: https://leetcode.com/problems/valid-palindrome/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {
    // convert to lower case
    // regular expression to remove all invalid char
    // return an array
    s = s.toLowerCase().match(/[A-Za-z0-9]/g);
    if (s == null || s.length == 0) return true;
    
    // compare if the reverse string is the same as origin string
    // if yes, it is palindrome
    s = s.join('');
    return s === s.split('').reverse().join('');
};