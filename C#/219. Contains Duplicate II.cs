/*
 * Link: https://leetcode.com/problems/contains-duplicate-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        
        for(var i = 0; i < nums.Length; i++) {
            if (map.ContainsKey(nums[i])) {
                if (i - map[nums[i]] <= k) return true;
                
                map[nums[i]] = i;
            }
            else {
                map.Add(nums[i], i);
            }
        }
        
        return false;
    }
}