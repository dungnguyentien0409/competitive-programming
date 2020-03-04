/**
 * Link: https://leetcode.com/problems/missing-number-in-arithmetic-progression/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} arr
 * @return {number}
 */
var missingNumber = function(arr) {
    var minDifferenceAbs = Number.MAX_SAFE_INTEGER;
    var minDifference = Number.MAX_SAFE_INTEGER;
    
    for (let i = 0; i < arr.length - 1; i++) {
        // the missing the number is the smallest distance
        if (Math.abs(arr[i + 1] - arr[i]) < minDifferenceAbs) {
            minDifferenceAbs = Math.abs(arr[i + 1] - arr[i]);
            minDifference = arr[i + 1] - arr[i];
        }
    }
    
    var res = 0;
    for (let i = 0; i < arr.length - 1; i++) {
        if (arr[i] + minDifference != arr[i + 1]) {
            res = arr[i] + minDifference;
        }
    }
    
    return res;
};