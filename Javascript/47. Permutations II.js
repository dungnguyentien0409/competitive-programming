/**
 * Link: https://leetcode.com/problems/permutations-ii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number[][]}
 */
var permuteUnique = function(nums) {
    nums.sort(function(a, b){return a - b});
    var res = [];
    var visited = Array(nums.length).fill(false);
    
    backTrack(res, [], nums, visited);
    
    return res;
};

function backTrack(res, tmp, nums, visited) {
    if (tmp.length == nums.length) res.push(tmp.slice(0));
    
    for (var i = 0; i < nums.length; i++) {
        // for each element, do back tracking except visited element and duplicated element
        if (visited[i] || i > 0 && nums[i] == nums[i - 1] && visited[i - 1]) continue;
        
        tmp.push(nums[i]);
        visited[i] = true;
        
        backTrack(res, tmp, nums, visited);
        
        tmp.pop();
        visited[i] = false;
    }
}