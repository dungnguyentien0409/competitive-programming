/*
 * Link: https://leetcode.com/problems/sentence-similarity/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool AreSentencesSimilar(string[] words1, string[] words2, IList<IList<string>> pairs) {
        if (words1.Length != words2.Length) return false;
        
        var map = new Dictionary<string, HashSet<string>>();
        
        foreach(var p in pairs) {
            if (!map.ContainsKey(p[0])) map.Add(p[0], new HashSet<string>());
            if (!map.ContainsKey(p[1])) map.Add(p[1], new HashSet<string>());
            
            map[p[0]].Add(p[1]);
            map[p[1]].Add(p[0]);
        }
        
        var len = words1.Length;
        for (var i = 0; i < len; i++) {
            if (words1[i].CompareTo(words2[i]) != 0
               && (!map.ContainsKey(words1[i]) || !map[words1[i]].Contains(words2[i])))
                return false;
        }
        
        return true;
    }
}