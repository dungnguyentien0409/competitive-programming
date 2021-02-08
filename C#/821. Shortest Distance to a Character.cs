/*
 * Link: https://leetcode.com/problems/shortest-distance-to-a-character/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] ShortestToChar(string s, char c) {
        var res = new int[s.Length];
        
        int val = s.Length;
        for (var i = 0; i < s.Length; i++) {
            res[i] = ++val;
            
            if (s[i] == c) {
                val = 0;
                res[i] = 0;
            }
        }
        
        val = s.Length;
        for (var i = s.Length - 1; i >= 0; i--) {
            res[i] = Math.Min(res[i], ++val);
            
            if (s[i] == c) {
                val = 0;
            }
        }
        
        return res;
    }
}