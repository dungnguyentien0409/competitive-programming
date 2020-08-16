/*
 * Link: https://leetcode.com/problems/longest-palindromic-substring/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string LongestPalindrome(string s) {
        int max = 0, head = 0;
        
        for (var i = 0; i < s.Length; i++) {
            int left = i, right = i;
            
            while(right + 1 < s.Length && s[right + 1] == s[right]) right++;
            
            while(left >= 0 && right < s.Length && s[left] == s[right]) {
                if (right - left + 1 > max) {
                    max = right - (head = left) + 1;
                }
                
                left--;
                right++;
            }
        }
        
        return s.Substring(head, max);
    }
}