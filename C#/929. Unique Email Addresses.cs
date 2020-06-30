/*
 * Link: https://leetcode.com/problems/unique-email-addresses/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumUniqueEmails(string[] emails) {
        var map = new Dictionary<string, HashSet<string>>();
        var count = 0;
        
        foreach(var e in emails) {
            var arr = e.Split(new char[] { '@' });
            
            if (!map.ContainsKey(arr[1])) map.Add(arr[1], new HashSet<string>());
            
            var customLocalName = CustomLocalName(arr[0]);
            if (!map[arr[1]].Contains(customLocalName)) {
                count++;
                map[arr[1]].Add(customLocalName);
            }
        }
        
        return count;
    }
    
    public string CustomLocalName(string name) {
        name = name.Replace(".", "");
        
        var index = name.IndexOf("+");
        
        return index > -1 ? name.Substring(0, index) : name;
    }
}