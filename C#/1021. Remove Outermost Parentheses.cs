/*
 * Link: https://leetcode.com/problems/remove-outermost-parentheses/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string RemoveOuterParentheses(string S) {
        var start = 0;
        var count = 0;
        var res = "";
        
        for(var i = 0; i < S.Length; i++) {
            if (S[i] == '(') count++;
            else {
                count--;
                
                if (count == 0 && i - start > 0) {
                    start++;
                    res += S.Substring(start, i - start);
                    start = i + 1;
                }
            }
        }
        
        return res;
    }
}