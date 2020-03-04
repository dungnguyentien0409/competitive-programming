/**
 * Link: https://leetcode.com/problems/valid-palindrome-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @return {boolean}
 */
var validPalindrome = function(s) {
    var left = 0;
    var right = s.length - 1;
    
    while(left < right) {
        // only remove when find the difference
        if (s[left] != s[right]) {
            // try to remove the left or the right element
            // return if it is true
            return (checkPalindrome(s.slice(0, left) + s.slice(left + 1, s.length)) || checkPalindrome(s.slice(0, right) + s.slice(right + 1, s.length)));
        }
        
        left++;
        right--;
    }
    
    // Dont have any case that s[left] != s[right]
    // is Palindrome
    return true;
};

function checkPalindrome(s) {
    // convert string to array, then reverse, then converse to string
   // if the origin string and convert string is the same then is palindrome
    return s === s.split('').reverse().join('');
}