/*
 * Link: https://leetcode.com/problems/verifying-an-alien-dictionary/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        var map = CreateMap(order);
        
        for (var i = 1; i < words.Length; i++) {
            var str1 = words[i - 1];
            var str2 = words[i];
            
            if (!Compare(str1, str2, map)) return false;
        }
        
        return true;
    }
    
    public bool Compare(string str1, string str2, Dictionary<int, int> map) {
        for (var i = 0; i < str1.Length && i < str2.Length; i++) {
            var i1 = map[str1[i]];
            var i2 = map[str2[i]];
            
            if (i1 != i2) return i1 <= i2;
        }
        
        return str1.Length < str2.Length;
    }
    
    public Dictionary<int, int> CreateMap(string order) {
        var map = new Dictionary<int, int>();
        
        for(var i = 0; i < order.Length; i++) {
            map.Add(order[i], i);
        }
        
        return map;
    }
}
}