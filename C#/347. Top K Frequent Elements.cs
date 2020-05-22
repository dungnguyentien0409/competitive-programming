/*
 * Link: https://leetcode.com/problems/top-k-frequent-elements/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = CreateMap(nums);
        var bucket = new List<IList<int>>(new List<int>[nums.Length + 1]);
        
        foreach(var item in map) {
            var n = item.Key;
            var frq = item.Value;
            
            if (bucket[frq] == null) bucket[frq] = new List<int>();
            
            bucket[frq].Add(n);
        }
        
        var res = new List<int>();
        
        for(var i = bucket.Count - 1; i >= 0; i--) {
            if (bucket[i] != null) {
                if (k == 0) return res.ToArray();
                
                res.AddRange(bucket[i]);
                
                k -= bucket[i].Count;
            }
        }
        
        return res.ToArray();
    }
    
    public Dictionary<int, int> CreateMap(int[] nums) {
        var map = new Dictionary<int, int>();
        
        foreach(var n in nums) {
            if (!map.ContainsKey(n)) map.Add(n, 0);
            
            map[n]++;
        }
        
        return map;
    }
}