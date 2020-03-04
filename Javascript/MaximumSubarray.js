/**
 * Problem: https://leetcode.com/problems/maximum-subarray/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number}
 */
var maxSubArray = function(nums) {
    if (nums.length == 0)
        return 0;
    var c_max = Number.MIN_SAFE_INTEGER;
    var f_max = Number.MIN_SAFE_INTEGER;
    
    for (var i = 0; i < nums.length; i++) {
        // foreach item update the local max and final max
        c_max = Math.max(c_max + nums[i], nums[i]);
        f_max = Math.max(f_max, c_max);
    }
    return f_max;
};

