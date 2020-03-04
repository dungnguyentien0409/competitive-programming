/* 
 * Link: https://leetcode.com/problems/group-anagrams/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new List<IList<string>>();
        var map = new Dictionary<string, List<string>>();
        
        foreach(var str in strs) {
            var key = new int[26];
            Array.Fill(key, 0);
            
            foreach (var c in str) {
                key[(char)c - (char)'a']++;
            }
            
            var strKey = string.Join(string.Empty, key);
            if (!map.ContainsKey(strKey)) {
                map.Add(strKey, new List<string>());
            } 
            map[strKey].Add(str);
        }
        
        var keys = map.Keys.ToList();
        foreach(var k in keys) {
            result.Add(map[k]);
        }
        
        return result;
    }
}