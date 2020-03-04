/*
 * Link: https://leetcode.com/problems/two-sum/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        
        for(var i = 0; i < nums.Length; i++) {
            var n = nums[i];
            if (map.ContainsKey(target - n)) {
                return new int[] {map[target - n], i};
            }
            
            if (!map.ContainsKey(n))
                map.Add(n, i);
        }
        
        return new int[] {0, 0};
    }
}