/*
 * Link: https://leetcode.com/problems/ambiguous-coordinates/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> AmbiguousCoordinates(string s) {
        var res = new List<string>();
        
        for (var len = 1; len < s.Length - 2; len++) {
            var s1 = s.Substring(1, len);
            var s2 = s.Substring(len + 1, s.Length - 2 - len);
            
            var list1 = GenerateDecimal(s1);
            var list2 = GenerateDecimal(s2);
            
            foreach(var item1 in list1) {
                foreach(var item2 in list2) {
                    var subRes = "(" + item1 + ", " + item2 + ")";
                    res.Add(subRes);
                }
            }
        }
        
        return res;
    }
    
    public List<string> GenerateDecimal(string s) {
        var res = new List<string>();
        int len = s.Length;
        
        if (s.Length == 0 || s.Length > 1 && s[0] == '0' && s[len - 1] == '0') return res;
        else if (s.Length == 1 || s[len - 1] == '0') res.Add(s);
        else if (len > 1 && s[0] == '0') res.Add("0." + s.Substring(1));
        else {        
            res.Add(s);
            for (var i = 1; i < len; i++) {
                var newS = s.Substring(0, i) + "." + s.Substring(i);
                res.Add(newS);
            }
        }
        
        return res;
    }
}