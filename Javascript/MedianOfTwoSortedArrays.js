/**
 * Problem: https://leetcode.com/problems/median-of-two-sorted-arrays/
 * Implement: Dung Nguyen Tien (Chris)
 * Idea by: Tushar Roy
 * Reference: https://www.youtube.com/watch?v=LPFhl65R7ww
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var findMedianSortedArrays = function(nums1, nums2) {
    if(nums1.length > nums2.length) {
        return findMedianSortedArrays(nums2, nums1);
    }
    
    var x = nums1.length;
    var y = nums2.length;
    
    var low = 0;
    var high = x;
    
    while (low <= high) {
        var partitionX = Math.floor((low + high) / 2);
        var partitionY = calculatePartitionY(x, y, partitionX);
        
        var maxLeftX = partitionX == 0 ? Number.MIN_SAFE_INTEGER : nums1[partitionX - 1];
        var minRightX = partitionX == x ? Number.MAX_SAFE_INTEGER: nums1[partitionX];
        
        var maxLeftY = partitionY == 0 ? Number.MIN_SAFE_INTEGER : nums2[partitionY - 1];
        var minRightY = partitionY == y ? Number.MAX_SAFE_INTEGER : nums2[partitionY];
        
        if (maxLeftX <= minRightY && maxLeftY <= minRightX) {
            if ((x + y) % 2 == 0) {
                return (Math.max(maxLeftX, maxLeftY) + Math.min(minRightX, minRightY)) / 2;
            }
            else {
                return Math.max(maxLeftX, maxLeftY);
            }
        }
        else if (maxLeftX > minRightY) {
            high = partitionX - 1;
        }
        else {
            low = partitionX + 1;
        }
    }
};

function calculatePartitionY(x, y, partitionX) {
    var partitionY = Math.floor((x + y + 1) / 2 - partitionX);
    return partitionY;
}