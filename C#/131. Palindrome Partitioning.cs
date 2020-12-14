/*
 * Link: https://leetcode.com/problems/palindrome-partitioning/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<IList<string>> Partition(string s) {
        var res = new List<IList<string>>();
        
        Backtrack(res, new List<string>(), s, 0);
        
        return res;
    }
    
    public void Backtrack(List<IList<string>> res, List<string> current, string s, int start) {
        if (start == s.Length) {
            res.Add(new List<string>(current));
        }
        
        for (var i = start; i < s.Length; i++) {
            if (IsPalindrome(s, start, i)) {
                current.Add(s.Substring(start, i - start + 1));
                
                Backtrack(res, current, s, i + 1);
                
                current.RemoveAt(current.Count - 1);
            }
        }
    }
    
    public bool IsPalindrome(string s, int start, int end) {
        while(start < end) {
            if (s[start++] != s[end--]) return false;
        }
        return true;
    }
}