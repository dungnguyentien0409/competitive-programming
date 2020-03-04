/**
 * Problem: https://leetcode.com/problems/find-k-closest-elements/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} arr
 * @param {number} k
 * @param {number} x
 * @return {number[]}
 */
var findClosestElements = function(arr, k, x) {
    var closestIndex = 0;
    var min = Number.MAX_SAFE_INTEGER;
    
    // find the closest element, push it to result
    for (var i = 0; i < arr.length; i++) {
        if (Math.abs(arr[i] - x) < min) {
            min = Math.abs(arr[i] - x);
            closestIndex = i;
        }
    } 
    
    // expland the range to left and right, add the closest element to result
    k--;
    var res = [arr[closestIndex]];
    var left = closestIndex - 1;
    var right = closestIndex + 1;
    while(k > 0) {
        if (left < 0) res.push(arr[right++]);
        else if (right >= arr.length) res.unshift(arr[left--]);
        
        else {
            // if left and right is equal, consider left
            if (Math.abs(arr[left] - x) <= Math.abs(arr[right] -x)) res.unshift(arr[left--]);
            else res.push(arr[right++]);
        }
        k--;
    }
    
    return res;
};