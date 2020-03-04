/**
 * Link: https://leetcode.com/problems/product-of-array-except-self/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number[]}
 */
var productExceptSelf = function(nums) {
    if (nums.length < 2) return [];
    
    var n = nums.length;
    var res = Array(n).fill(1);
    
    // product left value except self
    var leftValue = 1;
    for (var i = 1; i < n; i++) {
        leftValue *= nums[i - 1];
        res[i] = res[i] * leftValue;
    }

    // product with product of right value except sefl
    var rightValue = 1;
    for (var i = n - 2; i >= 0; i--) {
        rightValue *= nums[i + 1];
        res[i] *= rightValue;
    }
    
    return res;
};