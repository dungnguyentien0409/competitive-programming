public class Solution {
    public bool CanPartition(int[] nums) {
        int len = nums.Length, sum = nums.Sum();
        
        if (sum % 2 != 0) return false;
        sum /= 2;
        
        var dp = new bool[sum + 1];
        
        dp[0] = true;
        for(var i = 1; i <= len; i++) {
            var cur = dp.Clone() as bool[];
            int n = nums[i - 1];
            
            for (var j = 1; j <= sum; j++) {
                if (j >= n) {
                    cur[j] = dp[j] || dp[j - n];
                }
            }
            
            dp = cur;
        }
        
        return dp[sum];
    }
}