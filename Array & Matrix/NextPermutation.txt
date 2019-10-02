/**
 * Problem https://leetcode.com/problems/next-permutation/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var nextPermutation = function(nums) {
    // Idea: let say for 1,2,3,9,8,7
    // from the right, find the continously decrease string: 9, 8, 7
    // if the whole string is decreasing so return reversed string of it
    // i will point to the element after that decrease string: nums[i] == 3
    // find an item in the decreasing string to replace with i
    // that item must be right larger than i: 7 => 1,2,7,9,8,3
    // reverse that decrease string to get result: 1,2,7,3,8,9
    if (nums.length < 2) return nums;
    
    // find the i point to the element right before the decreas string
    var i = nums.length - 2;
    while(i >= 0 && nums[i] >= nums[i + 1]) {
        i--;
    }
      
    if (i < 0) return nums.reverse();
    
    // find j to swap
    var j = i + 1;
    for (j; j < nums.length; j++) {
        if (nums[j] <= nums[i]) {
            break;
        };
    }
    --j;

    //swap i, j
    [nums[i], nums[j]] = [nums[j], nums[i]];
    // reverse the decreasing string
    reverse(nums, i + 1, nums.length - 1);
};

function swap(nums, x, y) {
    var tmp = nums[x];
    nums[x] = nums[y];
    nums[y] = tmp;
}

function reverse(nums, left, right) {
    while(left < right) {
        
        [nums[left], nums[right]] = [nums[right], nums[left]];
        left++;
        right--;
    }
}