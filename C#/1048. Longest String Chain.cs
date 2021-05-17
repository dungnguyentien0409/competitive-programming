/*
 * Link: https://leetcode.com/problems/longest-string-chain/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LongestStrChain(string[] words) {
        Array.Sort(words, delegate(string a, string b) {
           return a.Length - b.Length; 
        });
        var map = new Dictionary<string, int>();
        int res = 0;
        
        foreach(var w in words) {
            int cur = 0;
            for (var i = 0; i < w.Length; i++) {
                var prev = w.Substring(0, i) + w.Substring(i + 1);
                
                if (map.ContainsKey(prev)) {
                    cur = Math.Max(cur, map[prev] + 1);
                }
            }
            
            if (map.ContainsKey(w)) {
                map[w] = Math.Max(map[w], cur);
            }
            else {
                map.Add(w, cur);
            }
            
            res = Math.Max(res, cur);
        }
        
        return res + 1;
    }
}