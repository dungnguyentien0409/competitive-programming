/**
 * Link: https://leetcode.com/problems/jump-game/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {boolean}
 */
var canJump = function(nums) {
    if (nums.length == 0) return 0;
    
    // for the range from i to curEnd
    // find the furthestJump of that range
    var furthestJump = 0;
    var curEnd = 0;
    
    for (var i = 0; i < nums.length; i++) {
        furthestJump = Math.max(i + nums[i], furthestJump);
	// When come to the end of the range
        if (i == curEnd) {
	    // If can jump to or over the end point then true
            if (furthestJump >= nums.length - 1) return true;
    	    //widen the range
            curEnd = furthestJump;
        }
    }
    
    return false;
};
