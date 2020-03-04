/**
 * Link: https://leetcode.com/problems/partition-to-k-equal-sum-subsets/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @param {number} k
 * @return {boolean}
 */
var canPartitionKSubsets = function(nums, k) {
    var sumSubset = getSumSubset(nums, k);
    var visited = new Set();
    
    if (sumSubset != Math.floor(sumSubset)) return false;

    var check = dfs(nums, sumSubset, 0, 0, visited, k);
    
    return check;
};

function dfs(nums, sumSubset, currentSum, current, visited, k) {
    if (k == 1) return true;
    if (currentSum > sumSubset) return false;
    if (currentSum == sumSubset) {
        return dfs(nums, sumSubset, 0, 0, visited, k - 1);
    }
    
    var res = false;
    for (var i = current; i < nums.length; i++) {
        if (!visited.has(i)) {
            visited.add(i);
            currentSum += nums[i];
            res = res || dfs(nums, sumSubset, currentSum, i + 1, visited, k);
            
            if (res == true) return true;
            
            visited.delete(i);
            currentSum -= nums[i];
        }
    }
    
    return false;
}

function getSumSubset(nums, k) {
    var sum = 0;
    for (var n of nums) sum += n;
    
    return sum / k;
}