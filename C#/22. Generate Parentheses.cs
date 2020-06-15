/*
 * Link: https://leetcode.com/problems/generate-parentheses/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var res = new List<string>();
        
        backtrack(res, new List<char>(), n, 0, 0);
        
        return res;
    }
    
    public void backtrack(List<string> res, List<char> current, int n, int open, int close) {
        if (open < close || open > n || close > n) return;
        if (open == close && open == n && close == n) {
            res.Add(new string(current.ToArray()));
        }
        
        current.Add('(');
        backtrack(res, current, n, open + 1, close);
        current.RemoveAt(current.Count - 1);

        current.Add(')');
        backtrack(res, current, n, open, close + 1);
        current.RemoveAt(current.Count - 1);
    }
}