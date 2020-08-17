/*
 * Link: https://leetcode.com/problems/palindrome-permutation-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> GeneratePalindromes(string s) {
        if (!Check(s)) return new List<string>();
        
        var res = new List<string>();
        var map = new int[256];
        var odd = BuildMap(map, s);
        var len = s.Length / 2;
        
        backtrack(res, "", map, len, odd);
        
        return res;
    }
    
    public void backtrack(List<string> res, string current, int[] map, int len, char? odd) {
        if (current.Length == len) {
            var reverse = new string(current.ToString().Reverse().ToArray());
            
            if (odd.HasValue) current += odd;
            
            res.Add(current + reverse);
            return;
        }
        
        for(var i = 0; i < map.Length; i++) {
            if (map[i] > 0) {
                map[i]--;
                
                backtrack(res, current + (char)i, map, len, odd);
                
                map[i]++;
            }
        }
    }
    
    public char? BuildMap(int[] map, string s) {
        foreach(var c in s) {   
            map[c]++;
        }
        
        char? odd = null;
        for(var i = 0; i < map.Length; i++) {
            if (map[i] % 2 != 0) {
                odd = (char)i;
            }
            
            map[i] /= 2;
        }
        
        return odd;
    }
    
    public bool Check(string s) {
        var set = new HashSet<char>();
        
        foreach(var c in s) {
            if (set.Contains(c)) set.Remove(c);
            else set.Add(c);
        }
        
        return set.Count <= 1;
    }
}