/*
 * Link: https://leetcode.com/problems/rotate-string/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool RotateString(string A, string B) {
        if (A.Length == 0 && B.Length == 0) return true;
        if (A.Length != B.Length) return false;
        
        var A1 = A + A;
        var kmp = new KMP();
        
        var res = kmp.KMPSearch(A1, B);
        
        return res >= 0;
    }
    
}

public class KMP {
    public KMP() {}
    
    public int KMPSearch(string word, string pattern) {
        if (word.Length == 0) return -1;
        
        int wIndex = 0, pIndex = 0;
        var computedPattern = buildComputedPattern(pattern);
        
        while(wIndex < word.Length) {
            if (word[wIndex] == pattern[pIndex]) {
                if (pIndex == pattern.Length - 1) return wIndex - pIndex;
                
                wIndex++;
                pIndex++;
            }
            else if (pIndex == 0) {
                wIndex++;
            }
            else {
                pIndex = computedPattern[pIndex - 1];
            }
        }
        
        return -1;
    }
    
    public int[] buildComputedPattern(string pattern) {
        var len = pattern.Length;
        var computed = new int[len];
        int prefix = 0, suffix = 1;
        
        while(suffix < len) {
            if (pattern[prefix] == pattern[suffix]) {
                computed[suffix] = prefix + 1;
                suffix++;
                prefix++;
            }
            else if (prefix == 0) {
                computed[suffix++] = 0;
            }
            else {
                prefix = computed[prefix - 1];
            }
        }
        
        return computed;
    }
}