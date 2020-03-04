/**
 * Link: https://leetcode.com/problems/play-with-chips/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} chips
 * @return {number}
 */
var minCostToMoveChips = function(chips) {
    // there are chips in odd position and even position. cause we can move by 2 without cose, now we move all even to 0 and odd to 1. now we count the total of chips in 0 and 1, return the min
    var odd = 0;
    var even = 0;
    
    for (var i = 0; i < chips.length; i++) {
        if (chips[i] % 2 == 0) even++;
        else odd++;
    }
    
    return Math.min(odd, even);
};