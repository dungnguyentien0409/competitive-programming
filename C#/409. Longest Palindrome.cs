/*
 * Link: https://leetcode.com/problems/longest-palindrome/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LongestPalindrome(string s) {
        var map = new Dictionary<char, int>();
        
        foreach(var c in s) {
            if (!map.ContainsKey(c)) map.Add(c, 0);
            
            map[c]++;
        }
        
        int len = 0, odd = 0;
        foreach(var k in map.Keys.ToList()) {
            if (map[k] % 2 == 0) {
                len += map[k];
            }
            else {
                len += map[k] - 1;
                odd = 1;
            }
        }
        
        return len + odd;
    }
}