/**
 * Link: https://leetcode.com/problems/two-sum/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    var map = {};
    
    for (var i = 0; i < nums.length; i++) {
        // with nums[i], need to find nums[j] = target - nums[i]
        if (!isNaN(map[target - nums[i]])) {
            return [map[target - nums[i]], i];
        }
        // if cant find, put nums[i] to map
        map[nums[i]] = i;
    }
    return[0, 0];
};