/**
 * Problem: https://leetcode.com/problems/combination-sum-ii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum2 = function(candidates, target) {
    candidates.sort(function(a, b) {return a - b;})
    
    var res = [];
    
    backTrack(res, [], candidates, target, 0);
    
    return res;
};

function backTrack(res, tmp, candidates, target, start) {
    if (target < 0) return;
    if (target == 0) res.push(tmp.slice(0));
    
    // for each element we do back track
    for (var i = start; i < candidates.length; i++) {
        if (i > start && candidates[i] == candidates[i - 1]) continue;
        
        // try first element
        tmp.push(candidates[i]);
        // backtrack
        backTrack(res, tmp, candidates, target - candidates[i], i + 1);
        tmp.pop();
    }
}