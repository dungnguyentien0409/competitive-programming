/*
 * Link: https://leetcode.com/problems/one-edit-distance/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool IsOneEditDistance(string s, string t) {
        int len = Math.Min(s.Length, t.Length);
        
        for (var i = 0; i < len; i++) {
            if (s[i] != t[i]) {
                if (s.Length == t.Length) {
                    return s.Substring(i + 1) == t.Substring(i + 1);
                }
                else if (s.Length > t.Length) {
                    return s.Substring(i + 1) == t.Substring(i);
                }
                else {
                    return s.Substring(i) == t.Substring(i + 1);
                }
            }
        }
        
        return Math.Abs(s.Length - t.Length) == 1;
    }
}