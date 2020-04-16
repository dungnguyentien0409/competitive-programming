/*
 * Link: https://leetcode.com/problems/valid-parenthesis-string/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CheckValidString(string s) {
        var res = backtrack(s, 0, 0);
        
        return res;
    }
    
    public bool backtrack(string s, int start, int count) {
        if (start >= s.Length) {
            if (count == 0) return true;
            
            return false;
        }
        
        for(var i = start; i < s.Length; i++) {
            if (s[i] == '(') count++;
            else if (s[i] == ')') {
                count--;
                
                if (count < 0) return false;
            }
            else if (s[i] == '*') {
                return backtrack(s, i + 1, count + 1)
                    || backtrack(s, i + 1, count - 1)
                    || backtrack(s, i + 1, count);
            }
        }
        
        return count == 0;
    }
}