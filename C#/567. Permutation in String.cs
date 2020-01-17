/*
 * Link: https://leetcode.com/problems/permutation-in-string/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var map = new Dictionary<char, int>();
        
        foreach(char c in s1) {
            if (!map.ContainsKey(c)) map.Add(c, 0);
            map[c]++;
        }
        
        int start = 0, end = 0;
        int count = s1.Length;
        
        while(end < s2.Length) {
            if (map.ContainsKey(s2[end]) && map[s2[end]]-- > 0) {
                count--;
            }
            end++;
            
            while(count == 0) {
                if (end - start == s1.Length) return true;
                
                if (map.ContainsKey(s2[start]) && map[s2[start]]++ == 0) {
                    count++;
                }
                start++;
            }
        }
        
        return false;
    }
}