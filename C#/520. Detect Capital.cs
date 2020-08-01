/*
 * Link: https://leetcode.com/problems/detect-capital/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool DetectCapitalUse(string word) {
        bool checkCapital = true, checkNonCapital = true;
        
        for (var i = 0; i < word.Length; i++) {
            var c = word[i];
            
            checkCapital = checkCapital & (c - 'A' >= 0 && 'Z' - c >= 0);
            
            if (i > 0) {
                checkNonCapital = checkNonCapital & (c - 'a' >= 0 && 'z' - c >= 0);   
            }
        }
        
        return checkCapital || checkNonCapital;
    }
}