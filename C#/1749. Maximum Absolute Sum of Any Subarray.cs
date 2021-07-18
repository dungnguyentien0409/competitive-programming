public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        int sum_min = nums[0], sum_max = nums[0];
        int res = Math.Max(sum_max, -sum_min);
        
        for (var i = 1; i < nums.Length; i++){
            sum_min += nums[i];
            sum_max += nums[i];
            
            sum_min = Math.Min(nums[i], sum_min);
            sum_max = Math.Max(nums[i], sum_max);
            res = Math.Max(res, Math.Max(sum_max, -sum_min));
        }
        
        return res;
    }
}