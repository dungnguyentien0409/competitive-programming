public class Solution {
    public int MaxCoins(int[] nums) {
        var dp = CreateDP(nums);
        int n = nums.Length;
        
        for(var len = 1; len <= n; len++) {
            for (var i = 0; i < n - len + 1; i++) {
                var j = i + len - 1;
                
                for(var k = i; k <= j; k++) {
                    int left = i == 0 ? 1 : nums[i - 1];
                    int right = j == n - 1 ? 1 : nums[j + 1];
                    int beforeLeft = k > i ? dp[i][k - 1]: 0; 
                    int beforeRight = k < j ? dp[k + 1][j] : 0;
                    
                    dp[i][j] = Math.Max(dp[i][j],
                                       nums[k] * left * right + beforeLeft + beforeRight);
                }
            }            
        }
        
        return dp[0][n - 1];
    }
    
    public int[][] CreateDP(int[] nums) {
        int len = nums.Length;
        var dp = new int[len][];
        
        for(var i = 0; i < len; i++) {
            dp[i] = new int[len];
        }
        
        return dp;
    }
}