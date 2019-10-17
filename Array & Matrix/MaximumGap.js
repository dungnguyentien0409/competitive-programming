/**
 * Problem: https://leetcode.com/problems/maximum-gap/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number}
 */
var maximumGap = function(nums) {
    if (nums.length < 2) return false;
    // use radixSort to sort the array
    nums = radixSort(nums);
    
    // loop all the array to find the max difference between successive elements
    var max = 0;
    for (var i = 0; i < nums.length - 1; i++) {
        max = Math.max(max, nums[i + 1] - nums[i]);
    }
    
    return max;
};

function radixSort(arr) {
    var max = getMax(arr);
    
    for (var i = 0; i < max; i++) {
        var buckets = Array(10).fill().map(() => []);
        for (var j = 0; j < arr.length; j++) {
            buckets[getDigit(arr[j], i)].push(arr[j]);
        }
        arr = [].concat(...buckets);
    }
    
    return arr;
}

function getMax(arr) {
    let max = 0;
    
    for (var n of arr) max = Math.max(max, n.toString().length);
    
    return max;
}

function getDigit(num, i) {
    return Math.floor(num / Math.pow(10, i)) % 10;
}