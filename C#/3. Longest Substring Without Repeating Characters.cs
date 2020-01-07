/*
 * Link: https://leetcode.com/problems/longest-substring-without-repeating-characters/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var map = new int[128];
        Array.Fill(map, 0);
        int d = 0;
        int begin = 0, end = 0;
        bool isRepeat = false;
        
        while(end < s.Length) {
            if (map[s[end++]]++ > 0) {
                isRepeat = true;
            }
            
            while(isRepeat) {
                // detect the repeat
                if (map[s[begin++]]-- == 2) {
                    isRepeat = false;
                }
            }
            
            d = Math.Max(d, end - begin);
        }
        
        return d;
    }
}