/*
 * Problem: https://leetcode.com/problems/count-and-say/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string CountAndSay(int n) {
        if (n < 1) return String.Empty;
        
        var init = "1";
        
        for (var i = 1; i < n; i++) {
            init = GenerateNext(init);
        }
        
        return init;
    }
    
    public string GenerateNext(string s) {
        var current = s[0];
        var count = 1;
        var res = "";
        
        for (var i = 1; i < s.Length; i++) {
            if (s[i] != current) {
                res += count.ToString() + current;
                current = s[i];
                count = 1;
            }
            else {
                count++;
            }
        }
        
        res += count.ToString() + current;
        return res;
    }
}