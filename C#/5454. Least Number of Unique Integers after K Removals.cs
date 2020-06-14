/*
 * Link: https://leetcode.com/problems/least-number-of-unique-integers-after-k-removals/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
        var len = arr.Length;
        var map = CreateMap(arr);
        var buckets = CreateBuckets(len);
        
        foreach(var item in map) {
            buckets[item.Value].Add(item.Key);
        }
        
        for (var i = 1; i <= len; i++) {
            var numbers = buckets[i].Count;
            
            for(var j = 0; j < numbers; j++) {
                if (k - i >= 0) {
                    k -= i;
                    buckets[i].RemoveAt(0);
                }
            }
        }
        
        var res = 0;
        
        foreach(var bucket in buckets) res += bucket.Count;
        
        return res;
    }
    
    public Dictionary<int, int> CreateMap(int[] arr) {
        var map = new Dictionary<int, int>();
        
        foreach(var n in arr) {
            if (!map.ContainsKey(n)) map.Add(n, 0);
            map[n]++;
        }
        
        return map;
    }
    
    public List<IList<int>> CreateBuckets(int n) {
        var buckets = new List<IList<int>>();
        
        for (var i = 0; i <= n; i++) {
            buckets.Add(new List<int>());
        }
        
        return buckets;
    }
}