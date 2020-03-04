/**
 * Link: https://leetcode.com/problems/subsets-ii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number[][]}
 */
var subsetsWithDup = function(nums) {
    nums.sort(function(a, b) {return a - b;});
    
    var res = [];
    backTrack(res, [], nums, 0);
    
    return res;
};

function backTrack(res, tmp, nums, start) {
    res.push(tmp.slice(0));
    
    for (var i = start; i < nums.length; i++) {
        // skip the duplicated item
        if (i > start && nums[i] == nums[i - 1]) continue;
        
        tmp.push(nums[i]);
        backTrack(res, tmp, nums, i + 1);
        tmp.pop();
    }
}