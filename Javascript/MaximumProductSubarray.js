/**
 * Problem: https://leetcode.com/problems/maximum-product-subarray/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number}
 */
var maxProduct = function(nums) {
    if (nums.length == 1) {
        return nums[0];
    }
    
    // max local store the positive max, min local store the negative min
    var res = nums[0], min_local = nums[0], max_local = nums[0];
    
    for (var i = 1; i < nums.length; i++) {
        var x = min_local * nums[i];
        var y = max_local * nums[i];
        
        // for each item update max and min
        min_local = Math.min(nums[i], Math.min(x, y));
        max_local = Math.max(nums[i], Math.max(x, y));
        
        res = Math.max(res, max_local);
    }
    
    return res;
};