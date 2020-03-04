/**
 * Problem: https://leetcode.com/problems/burst-balloons/
 * Dung Nguyen Tien (Chris)
 * Idea: from Tushar Roy
 * @param {number[]} nums
 * @return {number}
 */
var maxCoins = function(nums) {
    if (nums.length == 0) return 0;
    
    // dp[i][j] is the maximum score to get if burst ballon from i to j
    var n = nums.length;
    var dp = Array(n).fill().map(() => Array(n).fill(0));
    
    // for each time, consider to burst only len
    for (var len = 1; len <= n; len++) {
        for (var i = 0; i < n - len + 1; i++) {
            var j = i + len - 1;
            for (var k = i; k <= j; k++) {
                var leftValue = 1;
                var rightValue = 1;
                
                // the ballon at k is bursted, so consider to left and right value out of the range l
                if (i > 0) leftValue = nums[i - 1];
                if (j < n - 1) rightValue = nums[j + 1];
                
                var beforeLeft = 0;
                var beforeRight = 0;
                
                // the maximum score of bursting ballon left and right of ballon k (but in ln)
                if (k > i) beforeLeft = dp[i][k - 1];
                if (k < j) beforeRight = dp[k + 1][j];
                
                dp[i][j] = Math.max(dp[i][j], nums[k] * leftValue * rightValue + beforeLeft + beforeRight);
            }
        }
    }
    
    return dp[0][n - 1];
};