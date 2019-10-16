/**
 * Problem: https://leetcode.com/problems/132-pattern/solution/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {boolean}
 */
var find132pattern = function(nums) {
    if (nums.length < 3) return false;
    
    var i = 1;
    var s = 0;
    var check = []
    
    while(i < nums.length) {
        // find until there is a high peak
        if (nums[i - 1] > nums[i]) {
            // push the range before the high peak to the peak
            check.push([nums[s], nums[i - 1]]);
            s = i;
        }
        
        // which each i, check for every high peak
        for (var j = 0; j < check.length; j++) {
            var x = check[j];
            if (nums[i] > x[0] && nums[i] < x[1]) {
                return true;
            }
        }
        i++;
    }
    
    return false;
};