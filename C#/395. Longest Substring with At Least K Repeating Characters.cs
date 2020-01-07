/*
 * Link: https://leetcode.com/problems/longest-substring-with-at-least-k-repeating-characters/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LongestSubstring(string s, int k) {
        int d = 0;
        
        for (var noChar = 1; noChar <= 26; noChar++) {
            d = Math.Max(d,
                         LongestSubstringWithNoCharacter(s, k, noChar));
        }
        
        return d;
    }
    
    public int LongestSubstringWithNoCharacter(string s, int k, int noChar) {
        var map = new int[128];
        Array.Fill(map, 0);
        int countUnique = 0, countNoLessThanK = 0;
        int begin = 0, end = 0;
        int d = 0;
        
        while(end < s.Length) {
            if (map[s[end]]++ == 0) countUnique++;
            if (map[s[end]] == k) countNoLessThanK++;
            end++;
            
            while(countUnique > noChar) {
                if (map[s[begin]]-- == k) countNoLessThanK--;
                if (map[s[begin]] == 0) countUnique--;
                begin++;
            }
            
            if (countUnique == noChar && countUnique == countNoLessThanK) {
                d = Math.Max(d, end - begin);
            }
        }
        
        return d;
    }
}