/*
 * Link: https://leetcode.com/problems/maximum-size-subarray-sum-equals-k/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxSubArrayLen(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        var sum = 0;
        var maxLen = 0;
        
        map.Add(0, 0);
        for(var i = 0; i < nums.Length; i++) {
            sum += nums[i];
            
            if (map.ContainsKey(sum - k)) {
                maxLen = Math.Max(maxLen, i + 1 - map[sum - k]);   
            }
            
            if (!map.ContainsKey(sum))map.Add(sum, i + 1);
        }
        
        return maxLen;
    }
}