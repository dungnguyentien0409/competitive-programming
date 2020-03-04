/**
 * Link: https://leetcode.com/problems/subarray-sum-equals-k/
 * Author: Dung Nguyen Tien
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var subarraySum = function(nums, k) {
    var tmp = Array(nums.length + 1).fill(0);
    var sum = 0;
    
    for (var i = 1; i <= nums.length; i++) {
        sum += nums[i - 1];
        tmp[i] = sum;
    }
    
    var map = {};
    var count = 0;
    for (var i = 0; i < tmp.length; i++) {
        var s = tmp[i];
        if (map[s - k] != undefined) {
            count += map[s - k];
        };

        map[s] = (map[s] || 0) + 1;
    }
    
    return count;
};