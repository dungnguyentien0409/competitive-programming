/**
 * Link: https://leetcode.com/problems/largest-number/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {string}
 */
var largestNumber = function(nums) {
    if (nums.join('') == 0) return "0";
    
    //convert to string array
    var convert = nums.map(val => val + "");
    convert.sort(function(a, b) {
        return (b + a) - (a + b);
    })
    
    return convert.join('');
};
