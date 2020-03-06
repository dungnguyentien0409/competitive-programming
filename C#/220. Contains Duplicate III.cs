/*
 * Link: https://leetcode.com/problems/contains-duplicate-iii/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: dietpepsi
*/

public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (t < 0) return false;
        
        var map = new Dictionary<long, long>();
        var divisor = (long)t + 1;
        
        for (var i = 0; i < nums.Length; i++) {
            var number = getKey(nums[i], divisor);
            
            if (map.ContainsKey(number)
               || (map.ContainsKey(number - 1) && Math.Abs(nums[i] - map[number - 1]) < divisor)
               || (map.ContainsKey(number + 1) && Math.Abs(nums[i] - map[number + 1]) < divisor))
               return true;
            
            map[number] = (long)nums[i];
            
            if (i >= k) {
                var key = getKey(nums[i - k], divisor);
                map.Remove(key);
            }
        }
        
        return false;
    }
    
    public long getKey(long n, long d) {
        return n < 0 ? (n + 1) / d - 1 : n / d;
    }
}