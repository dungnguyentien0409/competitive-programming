/**
 * Problem: https://leetcode.com/problems/first-missing-positive/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number}
 */
var firstMissingPositive = function(nums) {
    if (nums.length == 0) return 1;
    
    for(var i = 0; i < nums.length; i++) {
        while(nums[i] > 0 && nums[i] <= nums.length && nums[nums[i] - 1] != nums[i]) {
            // find the correct number for position i => value i + 1, only nums[i] >0 cause if nums[i] < 0 => lack of that element
            swap(nums, i, nums[i] - 1);
        }
    }
    
    // find the missing element
    for (var i = 0; i < nums.length; i++) {
        if (nums[i] - 1 != i) return i + 1;
    }
    
    // if not, miss the last element, cause the current array has 0
    return nums.length + 1;
};

function swap(nums, x, y) {
    [nums[x], nums[y]] = [nums[y], nums[x]];
}