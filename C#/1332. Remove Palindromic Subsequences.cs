/*
 * Link: https://leetcode.com/problems/remove-palindromic-subsequences/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int RemovePalindromeSub(string s) {
        if (s.Length == 0) return 0;
        
        var arr = s.ToCharArray();
        Array.Reverse(arr);
        var reverse = new string(arr);
        
        if (s.CompareTo(reverse) == 0) return 1;
        
        return 2;
    }
}