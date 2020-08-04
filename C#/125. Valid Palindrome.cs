/*
 * Link: https://leetcode.com/problems/valid-palindrome/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool IsPalindrome(string s) {
        var n = s.Length;
        var left = 0;
        var right = n - 1;

        while (left < right) {
            if (!char.IsLetterOrDigit(s[left])) {
                left++;
            } else if (!char.IsLetterOrDigit(s[right])) {
                right--;
            } else {
                if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                    return false;
                }
                left++;
                right--;
            }
        }
        return true;
    }
}