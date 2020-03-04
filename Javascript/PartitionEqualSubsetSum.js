/**
 * Link: https://leetcode.com/problems/partition-equal-subset-sum/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {boolean}
 */
var canPartition = function(nums) {
    // This is knapsack problem
    if (nums.length <= 1) return false;
    
    var middleSum = getMiddleSum(nums);
    
    if (middleSum != Math.floor(middleSum)) return false;
    
    // find if we can pick items - sum to middle sum
    // dp[i][j] represents the posibility to pick i item sum equal to j
    var dp = Array(nums.length + 1).fill().map(() => Array(middleSum + 1).fill(false));
    dp[0][0] = true;
    
    for (var i = 1; i <= nums.length; i++) {
        for (var j = 1; j <= middleSum; j++) {
            var remainSum = j - nums[i - 1];
            if (remainSum < 0) {
                // cannot pick
                dp[i][j] = dp[i - 1][j];
            }
            else {
                // can pick - dicide to pick or not
                dp[i][j] = (true // pick
                           && dp[i - 1][remainSum]) // check if we can pick the remain
                           || dp[i - 1][j] // not pick
            }
        }
    }
    console.log(dp);
    return dp[nums.length][middleSum];
};

function getMiddleSum(nums) {
    var sum = 0;
    
    for (var n of nums) sum += n;
    
    return sum / 2;
}