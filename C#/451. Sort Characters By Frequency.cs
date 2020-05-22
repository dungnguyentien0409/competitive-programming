/*
 * Link: https://leetcode.com/problems/sort-characters-by-frequency/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string FrequencySort(string s) {
        var map = GetMap(s);
        var bucket = new List<IList<char>>(new List<char>[s.Length + 1]);
        
        foreach(var item in map) {
            var character = item.Key;
            var frequence = item.Value;
            
            if (bucket[frequence] == null) bucket[frequence] = new List<char>();
            
            bucket[frequence].Add(character);
        }
        
        var res = new StringBuilder();
        
        for (var i = bucket.Count - 1; i >= 0; i--) {
            var b = bucket[i];
            
            if (b != null) {
                foreach(var c in b) {
                    for(var time = 0; time < i; time++) {
                        res.Append(c);
                    }
                }
            }
        }
        
        return res.ToString();
    }
    
    public Dictionary<char, int> GetMap(string s) {
        var map = new Dictionary<char, int>();
        
        foreach(var c in s) {
            if (!map.ContainsKey(c)) map.Add(c, 0);
            
            map[c]++;
        }
        
        return map;
    }
}