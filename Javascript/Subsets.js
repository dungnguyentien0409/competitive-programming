/**
 * Problem: https://leetcode.com/problems/subsets/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number[][]}
 */
var subsets = function(nums) {
    var res = [];
    
    backTrack(res, [], nums, 0);
    
    return res;
};

function backTrack(res, tmp, nums, start) {
    res.push(tmp.slice(0));
    
    for (var i = start; i < nums.length; i++) {
        // pick the first solution
        tmp.push(nums[i]);
        // backtrack
        backTrack(res, tmp, nums, i + 1);
        tmp.pop();
    }
}