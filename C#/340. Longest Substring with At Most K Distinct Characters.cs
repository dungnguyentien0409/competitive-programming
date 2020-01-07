/*
 * Link: https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        int d = 0;
        
        for (var noDistinct = 1; noDistinct <= k; noDistinct++) {
            d = Math.Max(d, 
                         LongestSubstringNoDistinct(s, noDistinct));
        }
        
        return d;
    }
    
    public int LongestSubstringNoDistinct(string s, int noDistinct) {
        var map = new int[128];
        Array.Fill(map, 0);
        int d = 0, countDistinct = 0;
        int begin = 0, end = 0;
        
        while(end < s.Length) {
            if (map[s[end++]]++ == 0) countDistinct++;
            
            while(countDistinct > noDistinct) {
                if (--map[s[begin++]] == 0) countDistinct--;
            }
            
            if (countDistinct == noDistinct) {
                d = Math.Max(d, end - begin);
            }
        }
        
        return d;
    }
}