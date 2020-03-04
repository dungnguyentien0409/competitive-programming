/**
 * Link: https://leetcode.com/problems/next-greater-element-i/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Key: Monotonous Stack
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */
var nextGreaterElement = function(nums1, nums2) {
    var map = {};
    var st = [];
    
    for (var num of nums2) {
        // push emelent to stack 
        // untile find element bigger than stop of stack
        while (st.length > 0 && st[0] < num) {
            // set it as next bigger emelent for all smaller element in stack
            map[st.shift()] = num;
        }
        // push the element into stack to go on
        st.unshift(num);
    }
    
    // for each element in array nums1
    // find in map if it has next bigger element
    // than set the value
    for (var i = 0; i < nums1.length; i++) {
        nums1[i] = map[nums1[i]] ? map[nums1[i]] : -1;
    }
    
    return nums1;
};