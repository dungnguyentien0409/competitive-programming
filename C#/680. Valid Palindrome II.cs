/*
 * Problem: https://leetcode.com/problems/valid-palindrome-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool ValidPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;
        
        while(left < right) {
            if (s[left] == s[right]) {
                left++;
                right--;
            }
            else {
                var removeLeft = IsPalindrome(s, left + 1, right);
                var removeRight = IsPalindrome(s, left, right - 1);
                
                return removeLeft || removeRight;
            }
        }
        
        return true;
    }
    
    public bool IsPalindrome(string s, int left, int right) {
        while(left < right) {
            if (s[left] != s[right]) return false;
            
            left++;
            right--;
        }
        
        return true;
    }
}