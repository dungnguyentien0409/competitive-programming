/*
 * Link: https://leetcode.com/problems/find-duplicate-file-in-system/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<IList<string>> FindDuplicate(string[] paths) {
        var map = new Dictionary<string, List<string>>();
        var res = new List<IList<string>>();
        
        foreach(var path in paths) {
            var files = path.Split(" ");
            var root = files[0];
            
            for(var i = 1; i < files.Length; i++) {
                var file = files[i];
                
                int start = file.IndexOf("("), end = file.IndexOf(")") + 1 - start;
                var name = file.Substring(start, end);
                
                if (!map.ContainsKey(name)) map.Add(name, new List<string>());
                map[name].Add(root + "/" + file.Substring(0, start));
            }
        }
        
        foreach(var key in map.Keys) {
            if (map[key].Count == 1) continue;
            
            res.Add(map[key]);
        }
        
        return res;
    }
}