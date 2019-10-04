/**
 * Problem: https://leetcode.com/problems/next-greater-element-ii/submissions/
 * Author: Dung Tien Nguyen (Chris)
 * @param {number[]} nums
 * @return {number[]}
 */
var nextGreaterElements = function(nums) {
    var n = nums.length;
    var st = [];
    // init the result with all - 1
    var res = Array(n).fill(-1);
    
    // to find in one circle
    for (var i = 0; i < n * 2; i++) {
        var index = i % n;
        // push to stack until find an element larger than the top
        // pop the stack, set the value of larger element for it
        while(st.length > 0 && nums[st[0]] < nums[index]) {
            res[st.shift()] = nums[index];
        }
        
        // only push to stack to consider one way element
        // the for loop is to comeback and find the larger
        if (i < n) {
            st.unshift(i);
        }
    }
    
    return res;
};