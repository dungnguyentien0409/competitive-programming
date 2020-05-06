/*
 * Link: https://leetcode.com/problems/destination-city/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        var map = CreateMap(paths);
        
        foreach(var k in map.Keys.ToList()) {
            Console.WriteLine(k + " " + map[k].Count);
            if (map[k].Count == 0) {
                return k;
            }
        }
        
        return "";
    }
    
    public Dictionary<string, List<string>> CreateMap(IList<IList<string>> paths) {
        var map = new Dictionary<string, List<string>>();
        
        foreach(var path in paths) {
            string frm = path[0], to = path[1];
            
            if (!map.ContainsKey(frm)) map[frm] = new List<string>();
            if (!map.ContainsKey(to)) map[to] = new List<string>();
            
            map[frm].Add(to);
        }
        
        return map;
    }
}