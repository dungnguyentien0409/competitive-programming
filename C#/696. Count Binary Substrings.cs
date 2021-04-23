/*
 * Link: https://leetcode.com/problems/count-binary-substrings/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CountBinarySubstrings(string s) {
        int pre = 0, count = 1, res = 0;
        
        for (var i = 1; i < s.Length; i++) {
            if (s[i - 1] == s[i]) {
                count++;
            }
            else {
                res += Math.Min(pre, count);
                pre = count;
                count = 1;
            }
        }
        
        return res + Math.Min(pre, count);
    }
}