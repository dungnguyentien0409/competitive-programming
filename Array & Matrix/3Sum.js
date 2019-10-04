/**
 * Problem: https://leetcode.com/problems/3sum/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number[][]}
 */
var threeSum = function(nums) {
    // sort the arry ascending
    nums.sort(function(a, b){return a - b});
    var res = [];
    
    for(var i = 0; i < nums.length - 2; i++) {
        // save the first item
        var first = nums[i];
        var left = i + 1;
        var right = nums.length - 1;
        
        // left right, point to the others 2 items
        while(left < right) {
            var second = nums[left];
            var third = nums[right];
            var sum = first + second + third;
            
            if (sum == 0) {
                var tmp = [nums[i], nums[left++], nums[right--]];
                
                // check if the couples of them existed or not
                if (!res.some(s => {
                    return s[0].toString() + s[1].toString() + s[2].toString() == tmp[0].toString() + tmp[1].toString() + tmp[2].toString();
                })) res.push(tmp);
            }
            else if (sum > 0) right--;
            else left++;
        }
    }
    
    return res;
};