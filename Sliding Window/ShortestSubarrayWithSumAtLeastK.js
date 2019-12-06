/**
 * Problem: https://leetcode.com/problems/shortest-subarray-with-sum-at-least-k/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: lee215
 * @param {number[]} A
 * @param {number} K
 * @return {number}
 */
var shortestSubarray = function(A, K) {
    var n = A.length;
    var res = n + 1;
    // B[i + 1] represent the sum from 0 to i
    var B = Array(n + 1).fill(0);
    // deque is an array where i1 < i2 => B[i1] < B[i2]
    var deque = [];
    
    for (var i = 0; i < n; i++) B[i + 1] = B[i] + A[i];
    
    for (var i = 0; i <= n; i++) {
        while(deque.length > 0 && B[i] - B[deque[0]] >= K) {
            res = Math.min(res, i - deque.shift());
        }
        //
        while(deque.length > 0 && B[deque[deque.length - 1]] >= B[i]) {
            deque.pop();
        }
        deque.push(i);
    }
    
    return res <= n ? res : - 1;
};