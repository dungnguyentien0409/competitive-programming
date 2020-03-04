/**
 * Link: https://leetcode.com/problems/house-robber/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number}
 */
var rob = function(nums) {
    if (nums.length == 0) return 0;
    
    //dp[i] store the maximum value to rob at day i
    var dp = Array(nums.length + 1).fill(0);
    dp[1] = nums[0];
    
    for (var i = 2; i <= nums.length; i++) {
        // at day i we have 2 options, rob or not rob
        // if rob: dp[i] = dp[i - 2] + nums[i -1] cause cannot rob connected house
        // if not rob: dp[i] = dp[i-1]
        dp[i] = Math.max(dp[i-1], dp[i - 2] + nums[i - 1]);
    }
    
    return dp[nums.length];
};