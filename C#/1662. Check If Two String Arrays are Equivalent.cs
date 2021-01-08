/*
 * Link: https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        int iW1 = 0, iW2 = 0, i1 = 0, i2 = 0;
        int len1 = word1.Length, len2 = word2.Length;
        
        while(iW1 < word1.Length && iW2 < word2.Length) {
            if (i1 == word1[iW1].Length) {
                i1 = 0; iW1++;
            }
            if (i2 == word2[iW2].Length) {
                i2 = 0; iW2++;
            }
            if (iW1 == len1 && iW2 != len2 ||
               iW1 != len1 && iW2 == len2) return false;
            
            if (iW1 < len1 && iW2 < len2 
                && word1[iW1][i1] != word2[iW2][i2]) {
                return false;
            }
            
            i1++; i2++;
        }
        
        return true;
    }
}