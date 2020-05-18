/*
 * Link: https://leetcode.com/problems/rearrange-words-in-a-sentence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string ArrangeWords(string text) {
        var map = new Dictionary<int, List<string>>();
        var maxLen = 0;
        var arr = text.Split(new char[] { ' ' });
        
        
        foreach(var s in arr) {
            if (!map.ContainsKey(s.Length)) map.Add(s.Length, new List<string>());
            
            map[s.Length].Add(s);
            maxLen = Math.Max(maxLen, s.Length);
        }
        
        var res = "";
        for (var len = 0; len <= maxLen; len++) {
            if (map.ContainsKey(len)) {
                var current = string.Join(" ", map[len]);
                res = res.Length == 0 ? current : res + " " + current;
            }
        }
        
        res = res.ToLower();
        if (res.Length > 0) {
            res = res.Substring(0, 1).ToUpper() + res.Substring(1);
        }
        
        return res;
    }
}