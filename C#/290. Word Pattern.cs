/*
 * Link: https://leetcode.com/problems/word-pattern/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool WordPattern(string pattern, string str) {
        var arr = str.Split(' ');
        
        if (arr.Length != pattern.Length) return false;
        
        var map = new Dictionary<char, string>();
        var set = new HashSet<string>();
        
        for(var i = 0; i < pattern.Length; i++) {
            var c = pattern[i];
            var w = arr[i];
            
            //Console.WriteLine(c + " " + w);
            if (map.ContainsKey(c) && map[c].CompareTo(w) != 0) return false;
            if (set.Contains(w) && !map.ContainsKey(c)) return false;
            
            if (!set.Contains(w)) set.Add(w);
            map[c] = w;
        }
        
        return true;
    }
}