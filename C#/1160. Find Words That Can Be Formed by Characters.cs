/*
 * Link: https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CountCharacters(string[] words, string chars) {
        var count = 0;
        var map =CreateMap(chars);
        
        foreach(var w in words) {
            var tmp = new int[26];
            Array.Copy(map, tmp, 26);
            
            int len = 0;
            foreach(var c in w) {
                if (tmp[c - 'a']-- > 0) {
                    len++;
                }
            }
            
            if (len == w.Length) {
                count += len;
            }
        }
        
        return count;
    }
    
    public int[] CreateMap(string chars) {
        var map = new int[26];
        
        foreach(var c in chars) {
            map[c - 'a']++;
        }
        
        return map;
    }
}