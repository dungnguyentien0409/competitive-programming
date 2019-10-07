/**
 * Problem: https://leetcode.com/problems/sliding-window-maximum/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @param {number} k
 * @return {number[]}
 */
var maxSlidingWindow = function(nums, k) {
    // using double-ended queue which can pop and push first and last
    if(nums.length == 0 || k <= 0) return [];
    
    var n = nums.length;
    var res = Array(n - k + 1);
    var res_i = 0;
    // doubled-ended queue: the element in this queue is always increasing: and the length is always <= k
    // q store the index of maximum of k elements
    var q = [];
    
    for (var i = 0; i < n; i++) {
        // if the first element is out of k range, shift()
        while (q.length > 0 && q[0] < i - k + 1) q.shift();
        // if the last element is
        while (q.length > 0 && nums[q[q.length - 1]] < nums[i]) q.pop();
            
        q.push(i);
        // starting push to res after considering k element
        if (i >= k - 1) {
            res[res_i++] = nums[q[0]];
        }
    }
    
    return res;
};