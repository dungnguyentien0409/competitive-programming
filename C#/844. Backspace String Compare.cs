/*
 * Link: https://leetcode.com/problems/backspace-string-compare/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool BackspaceCompare(string S, string T) {
        var S1 = RemoveBackspace(S);
        var T1 = RemoveBackspace(T);
        
        return S1 == T1;
    }
    
    public string RemoveBackspace(string s) {
        var result = String.Empty;
        var count = 0;
        
        for (var i = s.Length - 1; i >= 0; i--) {
            if (s[i] == '#') count++;
            else {
                if (count > 0) {
                    count--;
                }
                else {
                    result = s[i] + result;
                }
            }
        }
        
        return result;
    }
}