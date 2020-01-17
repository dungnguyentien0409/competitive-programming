/*
 * Link: https://leetcode.com/problems/minimum-window-substring/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string MinWindow(string s, string t) {
        var map = new Dictionary<char, int>();
        
        foreach(char c in t) {
            if (!map.ContainsKey(c)) map.Add(c, 0);
            map[c]++;
        }
        
        int start = 0, end = 0;
        int min = Int32.MaxValue, count = t.Length;
        int head = 0;
        while(end < s.Length) {
            if (map.ContainsKey(s[end]) && map[s[end]]-- > 0) count--;
            end++;
            
            while(count == 0) {
                if (end - start < min) {
                    min = end - (head = start);
                }
                
                if (map.ContainsKey(s[start]) && map[s[start]]++ == 0) { 
                    count++;
                }
                start++;
            }
        }
        
        return min == Int32.MaxValue ? "" : s.Substring(head, min);
    }
}