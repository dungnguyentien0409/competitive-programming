/**
 * Link: https://leetcode.com/problems/russian-doll-envelopes/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} envelopes
 * @return {number}
 */
var maxEnvelopes = function(envelopes) {
    if (envelopes.length <= 1) return envelopes.length;
    
    // sort ascending by width and (descending by height if has the same width, by that way can pick the envelopes having the smallest height between those having the same width)
    envelopes.sort(function(a,b) {
        if (a[0] == b[0]) return b[1] - a[1];
        return a[0] - b[0];
    })
    
    // cause the width is always ascending, need to find the longest increasing height subsequence
    // using longest increasing height subsequence
    // reference: https://github.com/dungnguyentien0409/competitive-programming/blob/master/Dynamic%20Programming/LongestIncreasingSubsequence.txt
    var size = 0;
    var tails = Array(envelopes.length);

    for (var e of envelopes) {
        var index = binarySearch(tails, 0, size - 1, e[1]);
        tails[index] = e[1];
        if (index == size) size++;
    }
    
    return size;
};

function binarySearch(arr, left, right, x) {
    while(left < right) {
        var mid  = Math.floor((left + right) / 2);
        
        if (arr[mid] < x) left = mid + 1;
        else right = mid;
    }

    if (arr[left] < x) return left + 1;
    return left;
}