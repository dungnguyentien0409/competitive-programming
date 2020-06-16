/*
 * Link: https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        var map = CreateMap(groupSizes);
        var res = new List<IList<int>>();
        
        foreach(var item in map) {
            res.AddRange(GenerateGroups(item.Key, item.Value));
        }
        
        return res;
    }
    
    public List<IList<int>> GenerateGroups(int size, List<int> people) {
        var res = new List<IList<int>>();
        
        var current = new List<int>();
        
        foreach(var p in people) {
            current.Add(p);
            
            if (current.Count == size) {
                res.Add(new List<int>(current));
                current = new List<int>();
            }
        }
        
        if (current.Count > 0) res.Add(new List<int>(current));
        
        return res;
    }
    
    public Dictionary<int, List<int>> CreateMap(int[] groupSizes) {
        var map = new Dictionary<int, List<int>>();
        
        for (var i = 0; i < groupSizes.Length; i++) {
            var group = groupSizes[i];
            
            if (!map.ContainsKey(group)) map.Add(group, new List<int>());
            map[group].Add(i);
        }
        
        return map;
    }
}