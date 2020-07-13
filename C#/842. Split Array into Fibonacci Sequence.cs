/*
 * Link: https://leetcode.com/problems/split-array-into-fibonacci-sequence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> SplitIntoFibonacci(string S) {
        var res = new List<int>();
        
        backtrack(res, S, 0);
        
        return res;
    }
    
    public bool backtrack(List<int> res, string S, int pos) {
        if (pos == S.Length) return res.Count >= 3;
        
        for(var len = 1; len <= S.Length - pos; len++) {
            if ((len > 1 && S[pos] == '0') ||
                 Int64.Parse(S.Substring(pos, len)) > Int32.MaxValue)return false;
            
            var num = Int32.Parse(S.Substring(pos, len));
            var added = false;
            
            
            if (res.Count < 2) {
                res.Add(num);
                added = true;
            }
            else {
                if (num == res[res.Count - 1] + res[res.Count - 2]) {
                    res.Add(num);
                    added = true;
                }
                else if (num > res[res.Count - 1] + res[res.Count - 2]) {
                    return false;
                }
                else {
                    continue;
                }
            }
            
            var check = backtrack(res, S, pos + len);
            
            if (check) return true;
            if (added) res.RemoveAt(res.Count - 1);
        }
        
        return false;
    }
}