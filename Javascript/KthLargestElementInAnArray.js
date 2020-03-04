/**
 * Problem: https://leetcode.com/problems/kth-largest-element-in-an-array/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var findKthLargest = function(nums, k) {
    var sorted = [];
    
    for (var num of nums) {
        var index = binarySearch(sorted, num);
        sorted.splice(index, 0, num);
        
        if (sorted.length > k) sorted.shift();
    }
    
    return sorted[0];
};

function binarySearch(sorted, num) {
    if (sorted.length == 0) return 0;
    
    var left = 0;
    var right = sorted.length - 1;
    
    while(left < right) {
        var mid = Math.floor((left + right) / 2);
        
        if (sorted[mid] < num) left = mid + 1;
        else right = mid;
    }
    
    if (sorted[left] < num) return left + 1;
    return left;
}