/**
 * Link: https://leetcode.com/problems/continuous-subarray-sum/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Implement following idea of compton_scatter
 * @param {number[]} nums
 * @param {number} k
 * @return {boolean}
 */
var checkSubarraySum = function(nums, k) {
    var map = {};
    var sum = 0;
    
    map[0] = -1;
    for (var i = 0; i < nums.length; i++) {
        sum = sum + nums[i];
        
        if (k != 0) sum = sum % k;
        // when we meet sum again, mean that sum was added a number of multiple of k. so we substract the current i with the previous index to count the length: (a + n * k) % k == a % k
        if (map[sum] != undefined) {
            if (i - map[sum] > 1)
                return true;
        }
        else {
            map[sum] = i;
        }
    }
    
    return false;
};