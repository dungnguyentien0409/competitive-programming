/**
 * Problem: https://leetcode.com/problems/combinations/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @param {number} k
 * @return {number[][]}
 */
var combine = function(n, k) {
    var nums = getArray(n);
    var res = [];
    
    backtrack(res, [], nums, k, 0);
    
    return res;
};

function backtrack(res, current, nums, k, start) {
    if (current.length > k) return;
    if (current.length == k) {
        res.push(current.slice(0));
        return;
    }
    
    for (var i = start; i < nums.length; i++) {
        if (current.indexOf(nums[i]) == - 1) {
            current.push(nums[i]);
            backtrack(res, current, nums, k, i + 1);
            current.pop();
        }
    }
}

function getArray(n) {
    var res = [];
    
    for (var i = 1; i <= n; i++) res.push(i);
    
    return res;
}