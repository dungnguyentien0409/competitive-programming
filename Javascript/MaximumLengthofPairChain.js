/**
 * Link: https://leetcode.com/problems/maximum-length-of-pair-chain/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} pairs
 * @return {number}
 */
var findLongestChain = function(pairs) {
    // we order by the end, cause if we order by the start, the widest range can be first and can pick first, so we cannot pick other. otherwises, other by end will push the widest range to the end to pick last
    pairs.sort(function(a, b) { return a[1] - b[1] });
    console.log(pairs);
    var prev = pairs[0][1];
    var count = 1;
    
    for (var i = 1; i < pairs.length; i++) {
        if (pairs[i][0] > prev) {
            prev = pairs[i][1];
            count++;
        }
    }
    
    return count;
};