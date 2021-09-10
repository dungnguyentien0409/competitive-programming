public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        int len = nums.Length, res = 0;
        var dp = new int[len];
        
        for(var i = 2; i < len; i++) {
            if (nums[i] - nums[i - 1] == nums[i - 1] - nums[i - 2]) {
                dp[i] = dp[i - 1] + 1;
            }
            
            res += dp[i];
        }
        
        return res;
    }
}