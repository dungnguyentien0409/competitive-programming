/*
 * Link: https://leetcode.com/problems/top-k-frequent-words/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        var map = CreateMap(words);
        var buckets = new List<IList<string>>(new List<string>[words.Length + 1]);
        
        foreach(var item in map) {
            var w = item.Key;
            var frq = item.Value;
            
            if (buckets[frq] == null) buckets[frq] = new List<string>();
            
            buckets[frq].Add(w);
        }
        
        var res = new List<string>();
        for(var i = buckets.Count - 1; i >= 0; i--) {
            if (buckets[i] != null) {
                buckets[i] = buckets[i].OrderBy(o => o).ToList();
                
                for(var j = 0; j < buckets[i].Count; j++) {
                    res.Add(buckets[i][j]);
                    k--;
                    
                    if (k <= 0) return res;
                }
            }
        }
        
        return res;
    }
    
    public Dictionary<string, int> CreateMap(string[] words) {
        var map = new Dictionary<string, int>();
        
        foreach(var w in words) {
            if (!map.ContainsKey(w)) map.Add(w, 0);
            
            map[w]++;
        }
        
        return map;
    }
}