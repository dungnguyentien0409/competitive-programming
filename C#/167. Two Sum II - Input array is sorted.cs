/**
 * Link: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} numbers
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(numbers, target) {
    var left = 0, right = numbers.length - 1;
    var res = [];
    
    while (left < right) {
        var sum = numbers[left] + numbers[right];
        
        if (sum == target) {
            res.push(++left);
            res.push(++right);
            break;
        }
        else if (sum > target) right--;
        else left++
    }
    
    return res;
};