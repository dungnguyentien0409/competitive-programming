/*
 * Link: https://leetcode.com/problems/longest-substring-with-at-most-two-distinct-characters/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        var map = new int[128];
        Array.Fill(map, 0);
        int d = 0, countDistinct = 0;
        int begin = 0, end = 0;
        
        while(end < s.Length) {
            if (map[s[end++]]++ == 0) countDistinct++;
            
            while(countDistinct > 2) {
                if (--map[s[begin++]] == 0) countDistinct--;
            }
            
            if (countDistinct <= 2) {
                d = Math.Max(d, end - begin);
            }
        }
        
        return d;
    }
}