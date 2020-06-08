/*
 * Link: https://leetcode.com/problems/repeated-substring-pattern/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        var computedPattern = BuildComputedPattern(s);
        var len = computedPattern[s.Length - 1];
        var n = s.Length;
        
        return len > 0 && n % (n - len) == 0;
    }
    
    public int[] BuildComputedPattern(string pattern) {
        int prefix = 0, suffix = 1;
        var computedPattern = new int[pattern.Length];
        
        while(suffix < pattern.Length) {
            if (pattern[prefix] == pattern[suffix]) {
                computedPattern[suffix] = prefix + 1;
                suffix++;
                prefix++;
            }
            else if (prefix == 0) {
                computedPattern[suffix++] = 0;
            }
            else {
                prefix = computedPattern[prefix - 1];
            }
        }
        
        return computedPattern;
    }
}