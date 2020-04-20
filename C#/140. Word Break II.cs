/*
 * Link: https://leetcode.com/problems/word-break-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        var cache = new Dictionary<string, List<string>>();
        var result = new List<string>();
        
        cache.Add("", new List<string>());
        backtrack(s, wordDict, cache);
        
        return cache[s];
    }
    
    public List<string> backtrack(string s, IList<string> wordDict, Dictionary<string, List<string>> cache) {
        if (cache.ContainsKey(s)) {
            return cache[s];
        }
        
        var res = new List<string>();
        foreach(var w in wordDict) {
            if (w.Length <= s.Length && s.Substring(0, w.Length) == w) {
                Console.WriteLine(s + " " + w);
                var newStr = s.Substring(w.Length);
                var total = backtrack(newStr, wordDict, cache);
                
                if (total.Count == 0 && newStr.Length == 0) {
                    res.Add(w);
                }
                else {
                    foreach(var t in total) {
                        res.Add(w + " " + t);
                    }
                }
            }
        }
        
        return cache[s] = res;
    }
}