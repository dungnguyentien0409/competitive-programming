/**
 * Link: https://leetcode.com/problems/permutations/submissions/
 * Owner: Dung Nguyen Tien
 * @param {number[]} nums
 * @return {number[][]}
 */

var permute = function(nums) {
    var res = [];
    
    backTrack(res, [], nums);
    
    return res;
};

function backTrack(res, tmp, nums) {
    if (tmp.length == nums.length) res.push(tmp.slice(0));
    
    for (var i = 0; i < nums.length; i++) {
        if (tmp.indexOf(nums[i]) > -1) continue;
        
        tmp.push(nums[i]);
        backTrack(res, tmp, nums);
        tmp.pop();
    }
}