/*
 * Link: https://leetcode.com/problems/html-entity-parser/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string EntityParser(string text) {
        var map = CreateMap();
        
        foreach(var item in map) {
            text = text.Replace(item.Key, item.Value);
        }
        
        return text;
    }
    
    public Dictionary<string, string> CreateMap() {
        var map = new Dictionary<string, string>();
        
        map.Add("&gt;", ">");
        map.Add("&lt;", "<");
        map.Add("&amp;", "&");
        map.Add("&apos;", "'");
        map.Add("&quot;", "\"");
        map.Add("&frasl;", "/");
        
        return map;
    }
}