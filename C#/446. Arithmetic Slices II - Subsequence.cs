public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        int len = nums.Length, total = 0;
        var dp = new Dictionary<long, int>[len];
        
        for(var i = 0; i < len; i++) {
            dp[i] = new Dictionary<long, int>();
        }
        
        for(var i = 0; i < len; i++) {
            for (var j = 0; j < i; j++) {
                long diff = (long)nums[i] - (long)nums[j];
                
                dp[i][diff] = dp[i].GetValueOrDefault(diff) 
                    + dp[j].GetValueOrDefault(diff) + 1;
                
                total += dp[j].GetValueOrDefault(diff);
            }
        }
        
        return total;
    }
}