/**
 * Link: https://leetcode.com/problems/find-k-th-smallest-pair-distance/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var smallestDistancePair = function(nums, k) {
    nums.sort(function(a, b) {return a - b});
    
    var low = Number.MAX_SAFE_INTEGER;
    var high = nums[nums.length - 1] - nums[0];
    
    for (var i = 0; i < nums.length - 1; i++) {
        low = Math.min(low, nums[i + 1] - nums[i]);
    }
   
    while(low < high) {
        var mid = Math.floor(low + (high - low) / 2);
        // count the pair distance <= mid, having count pair
        var count = countPairs(nums, mid);
        
        // if count pair < k => not come to k-index, low = mid + 1
        if (count < k) {
            low = mid + 1;
        }
        else {
            high = mid;
        }
    }
    
    return low;
};

// Returns number of pairs with absolute difference less than or equal to mid.
function countPairs(nums, mid) {
    var n = nums.length, res = 0;
    
    for (var i = 0; i < n; ++i) {
        var j = i + 1;
        while (j < n && nums[j] - nums[i] <= mid) j++;
        // from j - 1 to i is the pair that having difference less than or equal to mid.
        // we can form (j - 1) - i pair without reversing
        res += j - i - 1;
    }
    return res;
}