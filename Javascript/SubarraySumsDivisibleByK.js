/**
 * Problem: https://leetcode.com/problems/subarray-sums-divisible-by-k/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} A
 * @param {number} K
 * @return {number}
 */
var subarraysDivByK = function(A, K) {
    var count = 0;
    var map = {};
    var sum = 0;
    
    map[0] = 1;
    for (var i = 0; i < A.length; i++) {
        sum = sum + A[i];
        sum = (sum % K + K) % K
        if (map[sum] != undefined) {
            count += map[sum];
            map[sum] += 1;
        }
        else {
            map[sum] = 1;
        }
    }

    return count;
};