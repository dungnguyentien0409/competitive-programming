
/*
 * Link: https://leetcode.com/problems/jump-game-vi/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public int MaxResult(int[] nums, int k) {
        if (nums.Length == 0) return 0;
        
        var q = new List<int>();
        int len = nums.Length, sum = 0;
        var dp = new int[len];
        
        int i = 0;
        while(i < len) {
            while(q.Count > 0 && i - q[0] > k) q.RemoveAt(0);
            
            int n = nums[i];
            dp[i] = q.Count == 0 ? n : dp[q[0]] + n;
            while(q.Count > 0 && dp[q[q.Count - 1]] < dp[i]) q.RemoveAt(q.Count - 1);
            
            q.Add(i++);
        }
        
        return dp[len - 1];
    }
}