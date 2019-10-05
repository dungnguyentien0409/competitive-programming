/**
 * Problem: https://leetcode.com/problems/house-robber-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number}
 */
var rob = function(nums) {
    if (nums.length == 0) return  0;
    if (nums.length == 1) return nums[0];
    
    //dp save the maximum rob at day i
    var n = nums.length;
    var dpFirstHouse = Array(n).fill(0);
    var dpSecondHouse = Array(n).fill(0);
    
    dpFirstHouse[1] = nums[0];
    // this line is useless because i start from 2, anyway the dpSecondHouse will pick the second house for first because dp[i-1] and dp[i-2] of i==2 are 0
    //dpSecondHouse[2] = nums[1];
    
    for (var i = 2; i <= n; i++) {
        dpFirstHouse[i] = Math.max(dpFirstHouse[i - 1], dpFirstHouse[i - 2] + nums[i - 1]);
        dpSecondHouse[i] = Math.max(dpSecondHouse[i - 1], dpSecondHouse[i - 2] + nums[i - 1]);
    }
    
    // rob the first house cannot rob the end, so just take to n - 1
    // rob the second house can rob the end, take to n
    return Math.max(dpFirstHouse[n - 1], dpSecondHouse[n]);
};