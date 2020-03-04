/**
 * Link: https://leetcode.com/problems/minimum-size-subarray-sum/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} s
 * @param {number[]} nums
 * @return {number}
 */
var minSubArrayLen = function(s, nums) {
    var queue = [];
    var sum = 0;
    var min_len = Number.MAX_SAFE_INTEGER;
    var i = 0;
    
    while(i < nums.length) {
        var n = nums[i];
        
        if (sum < s) {
            queue.push(n);
            sum += n; 
            i++;
        }
        else {
            min_len = Math.min(min_len, queue.length);
            sum -= queue[0];
            queue.shift();
        }
    }
    
    while(sum >= s) {
        if (sum >= s) {
            min_len = Math.min(min_len, queue.length);
        }
        
        sum -= queue[0];
        queue.shift();
    }
    
    return min_len == Number.MAX_SAFE_INTEGER ? 0 : min_len;
};