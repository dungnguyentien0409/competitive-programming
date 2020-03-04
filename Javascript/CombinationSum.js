/**
 * Link: https://leetcode.com/problems/combination-sum/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum = function(candidates, target) {
    candidates.sort(function(a,b) {return a - b;})
    
    var res = [];
    backTrack(res, [], candidates, target, 0);
    
    return res;
};

function backTrack(res, tmp, nums, target, start) {
    if (target < 0) return;
    else if (target == 0) res.push(tmp.slice(0));
    else {
        for (var i = start; i < nums.length; i++) {
            // pick one solution
            tmp.push(nums[i]);
            //back track
            backTrack(res, tmp, nums, target - nums[i], i);
            tmp.pop();
        }
    }
}