/*
 * Link: https://leetcode.com/problems/length-of-last-word/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LengthOfLastWord(string s) {
        var count = 0;
        var tmp = 0;
        
        for (var i = 0; i < s.Length; i++) {
            if (s[i] == ' ') count = 0;
            else tmp = ++count;
        }
        
        return count == 0 ? tmp : count;
    }
}