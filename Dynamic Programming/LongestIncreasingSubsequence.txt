/**
 * Problem: https://leetcode.com/problems/longest-increasing-subsequence/solution/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: https://www.geeksforgeeks.org/longest-monotonically-increasing-subsequence-size-n-log-n/
 * @param {number[]} nums
 * @return {number}
 */
var lengthOfLIS = function(nums) {
    // let say from nums[i] we can get lots of increasing substring cointaing one to nums.length items
    // dp[i] stores the value of the continuosly increasing substring(has i length) has the smallest ending 
    var tails = new Array(nums.length);
    var size = 0;
    for (var x of nums) {
        // foreach x we do 3 things
        // if x bigger than all elements in tails, push it to tails
        // if x is the smallest replace the element at 0
        // other: find place to insert x
        //  please follow the reference link to understand this step
        var index = binarySearch(tails, 0, size - 1, x);
        tails[index] = x;
        if (index == size) ++size;
    }
    return size;
};

function binarySearch(tails, left, right, target) {
    while(left < right) {
        var mid = Math.floor((left + right) / 2);
        
        if (tails[mid] < target) left = mid + 1;
        else right = mid;
    }
    
    if (tails[left] < target) return left + 1;
    return left;
}