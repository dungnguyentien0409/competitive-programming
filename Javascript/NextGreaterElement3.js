/**
 * Link: https://leetcode.com/problems/next-greater-element-iii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @return {number}
 */
var nextGreaterElement = function(n) {
    // Idea: let say for 1,2,3,9,8,7
    // from the right, find the continously decrease string: 9, 8, 7
    // if the whole string is decreasing so return reversed string of it
    // i will point to the element after that decrease string: nums[i] == 3
    // find an item in the decreasing string to replace with i
    // that item must be right larger than i: 7 => 1,2,7,9,8,3
    // reverse that decrease string to get result: 1,2,7,3,8,9
    var nums = n.toString().split('');
    
    if (nums.length < 2) return -1;
    
    var i = nums.length - 2;
    while(i >= 0 && nums[i] >= nums[i + 1]) {
        i--;
    }
    
    if (i < 0) return -1;
    
    var j = i + 1;
    while(j < nums.length && nums[j] > nums[i]) j++;
    j--;

    [nums[i], nums[j]] = [nums[j], nums[i]];
    reverse(nums, i + 1, nums.length - 1);
    var res = parseInt(nums.join(''));
    
    return res > Math.pow(2, 31) ? - 1 : res;
};

function reverse(nums, left, right) {
    while(left < right) {
        [nums[left], nums[right]] = [nums[right], nums[left]];
        left++;
        right--
    }
}