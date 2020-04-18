/*
 * Link: https://leetcode.com/problems/the-k-th-lexicographical-string-of-all-happy-strings-of-length-n/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string GetHappyString(int n, int k) {
        var res = new List<string>();
        
        backtrack(n, k, "", res);
        
        return res.Count >= k ? res[k - 1] : "";
    }
    
    public void backtrack(int n, int k, string current, List<string> res) {
        if (k < 0 ||
           (current.Length > 1 && current[current.Length - 1] == current[current.Length - 2]))
            return;
        
        if (current.Length == n) {
            res.Add(new string (current));
            k--;
            return;
        }
        
        foreach(var c in "abc") {
            backtrack(n, k, current + c, res);
        }
    }
}