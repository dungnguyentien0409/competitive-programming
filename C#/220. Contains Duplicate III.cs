/*
 * Link: https://leetcode.com/problems/contains-duplicate-iii/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: dietpepsi
*/

public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (t < 0) return false;
        
        var map = new Dictionary<long, long>();
        
        for (var i = 0; i < nums.Length; i++) {
            var n = nums[i];
            var key = GetKey(n, t + 1);
            
            Console.WriteLine(n + " " + key);
            
            if (map.ContainsKey(key) && (long)Math.Abs(map[key] - n) <= t) return true;
            if (map.ContainsKey(key - 1) && (long)Math.Abs(map[key - 1] - n) <= t) return true;
            if (map.ContainsKey(key + 1) && (long)Math.Abs(map[key + 1] - n) <= t) return true;
            
            map[key] = n;
            
            if (i >= k) {
                var k_remove = GetKey(nums[i - k], t + 1);
                map.Remove(k_remove);
            }
        }
        
        return false;
    }
    
    public long GetKey(int n, int t) {
        return (long) n / t;
    }
}