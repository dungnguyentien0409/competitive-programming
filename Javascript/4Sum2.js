/**
 * Problem: https://leetcode.com/problems/4sum-ii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} A
 * @param {number[]} B
 * @param {number[]} C
 * @param {number[]} D
 * @return {number}
 */
var fourSumCount = function(A, B, C, D) {
    var count = 0;
    var res = {};
    
    // find a sum of A[i] and B[i]
    for (var i = 0; i < A.length; i++) {
        for (var j = 0; j < A.length; j++) {
            var sum = (A[i] + B[j]) + "";
            res[sum] = res[sum] ? res[sum] + 1 : 1;
        }
    }
    
    // check if that -sum existed in C[i] + D[j]
    // if existed: check how many of them in A => the count += that quantities
    for (var i = 0; i < C.length; i++) {
        for (var j = 0; j < D.length; j++) {
            var sum = (-(C[i] + D[j])) + "";
            if (res[sum]) {
                count += res[sum];
            }
        }
    }
    
    return count;
};