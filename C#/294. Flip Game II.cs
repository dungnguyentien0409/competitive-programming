/*
 * Link: https://leetcode.com/problems/flip-game-ii/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: conghao321
*/

public class Solution {
    public bool CanWin(string s) {
        for (var i = 1; i < s.Length; i++) {
            // length = end - start + 1
            if (s.Substring(i - 1, 2) == "++" &&
               !CanWin(s.Substring(0, i - 2 - 0 + 1) 
                       + "--" 
                       + s.Substring(i + 1, s.Length - 1 - (i + 1) + 1))) {
                return true;
            }
        }
        
        return false;
    }
}