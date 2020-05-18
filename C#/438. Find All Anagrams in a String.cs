/*
 * Link: https://leetcode.com/problems/find-all-anagrams-in-a-string/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var result = new List<int>();
        var map = CreateMap(p);
        int begin = 0, end = 0;
        int count = p.Length;
        
        while(end < s.Length) {
            if (map.ContainsKey(s[end]) && map[s[end]]-- > 0) {
                count--;
            }
            end++;
            
            while (count == 0) {
                if (map.ContainsKey(s[begin]) && map[s[begin]]++ == 0) {
                    count++;
                }
                
                if (end - begin == p.Length) {
                    result.Add(begin);
                }
                begin++;
            }
        }
        
        return result;
    }
    
    public Dictionary<char, int> CreateMap(string p) {
        var map = new Dictionary<char, int>();
        
        foreach(var c in p) {
            if (!map.ContainsKey(c)) map.Add(c, 0);
            
            map[c]++;
        }
        
        return map;
    }
}