/*
 * Link: https://leetcode.com/problems/find-and-replace-pattern/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        var res = new List<string>();
        
        foreach(var w in words) {
            if (Check(w, pattern)) {
                res.Add(w);
            }
        }
        
        return res;
    }
    
    public bool Check(string w, string p) {
        if (p.Length != w.Length) return false;
        
        var map = new Dictionary<char, char>();
        var set = new HashSet<char>();
        for(var i = 0; i < w.Length; i++) {
            if (map.ContainsKey(p[i]) && map[p[i]] != w[i]) return false;
            if (!map.ContainsKey(p[i]) && set.Contains(w[i])) return false;
            
            if (!set.Contains(w[i])) set.Add(w[i]);
            if (!map.ContainsKey(p[i])) {
                map.Add(p[i], w[i]);
            }
        }
        
        return true;
    }
}