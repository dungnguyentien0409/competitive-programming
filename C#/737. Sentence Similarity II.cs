/*
 * Link: https://leetcode.com/problems/sentence-similarity-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public bool AreSentencesSimilarTwo(string[] words1, string[] words2, IList<IList<string>> pairs) {
        if (words1.Length != words2.Length) return false;
        
        var map = new Dictionary<string, string>();
        
        foreach(var p in pairs) {
            var p1 = Find(map, p[0]);
            var p2 = Find(map, p[1]);
            
            if (p1.CompareTo(p2) != 0) {
                if (!map.ContainsKey(p1)) map.Add(p1, "");
                
                map[p1] = p2;
            }
        }
        
        for (var i = 0; i < words1.Length; i++) {
            if (words1[i].CompareTo(words2[i]) != 0 &&
               Find(map, words1[i]).CompareTo(Find(map, words2[i])) != 0) return false;
        }
        
        return true;
    }
    
    public string Find(Dictionary<string, string> map, string w) {
        if (!map.ContainsKey(w)) map.Add(w, w);
        
        return map[w].CompareTo(w) == 0 ? w : Find(map, map[w]);
    }
}