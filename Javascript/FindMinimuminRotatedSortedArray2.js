/**
 * Problem: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number}
 */
var findMin = function(nums) {
    //for example: 5,5,5,6,7,1,2,3,4,5,5
    var left = 0, right = nums.length - 1;
    
    while(left < right) {
        var mid = left + (right - left) / 2;
        
        if (nums[mid] < nums[right])
            // mid is in 1 to 5
            right = mid;
        else if (nums[mid] > nums[right])
            // mid belong to 6,7 => eliminate bigger number: 5,5,5,6
            left = mid + 1;
        else // mid is in 5,5,5,6,7 or 5,5
            if (right != 0 && nums[right-1] <= nums[right])
                right--;
            else // nums[right] == 0 || nums[right - 1] > nums[right]
                return nums[right];
    }
    return nums[left];
};