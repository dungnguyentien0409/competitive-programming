/*
 * Link: https://leetcode.com/problems/restore-ip-addresses/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        var result = new List<string>();
        
        backtrack(s, 0, new List<string>(), result);
        
        return result;
    }
    
    public void backtrack(string s, int start, List<string> current, List<string> res) {
        if (current.Count == 3) {
            var last = s.Substring(start);

            if (IsValidIP(last)) {
                current.Add(last);
                
                var ip = string.Join(".", new List<string>(current));
                
                current.RemoveAt(current.Count - 1);
                
                res.Add(ip);
            }
            
            return;
        }
        
        for (var len = 1; len <=  3; len++) {
            if (start + len <= s.Length) {
                var thisByte = s.Substring(start, len);

                if (IsValidIP(thisByte)) {
                    current.Add(thisByte);
                    
                    backtrack(s, start + len, current, res);
                    
                    current.RemoveAt(current.Count - 1);
                }
            }
        }
    }
    
    public bool IsValidIP(string s){
        if(s.Length > 3 
           || s.Length == 0 
           || (s[0] == '0' && s.Length > 1) 
           || Int32.Parse(s) > 255) {
            return false;
        }
        
        return true;
    }
}