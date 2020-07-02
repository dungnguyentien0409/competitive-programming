/*
 * Link: https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string MinRemoveToMakeValid(string s) {
        var st = new Stack<int>();
        var check = new bool[s.Length];
        int count = 0;
        
        Array.Fill(check, false);
        for (var i = 0; i < s.Length; i++) {
            var c = s[i];
            
            if (c == '(') {
                st.Push(i);
            }
            else if (c == ')') {
                if (st.Count > 0) {
                    check[i] = true;
                    check[st.Pop()] = true;
                }
            }
            else {
                check[i] = true;
            }
        }
        
        var res = new StringBuilder();
        for (var i = 0; i < s.Length; i++) {
            if (check[i]) res.Append(s[i]);
        }
        
        return res.ToString();
    }
}