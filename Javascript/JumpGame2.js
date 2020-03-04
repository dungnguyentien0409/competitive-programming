/**
 * Link: https://leetcode.com/problems/jump-game-ii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {number}
 */
var jump = function(nums) {
    var jumps = 0, curEnd = 0, curFarthest = 0;
	for (var i = 0; i < nums.length - 1; i++) {
        // pick the farthest before curEnd, cause the farthest jump is the smalles step
		curFarthest = Math.max(curFarthest, i + nums[i]);
        // if i jump to end then update the i, and the farthest its can reach from the point before curEnd
		if (i == curEnd) {
			jumps++;
			curEnd = curFarthest;
		}
	}
    // if can jump over end is true, return the jumps
	return curEnd >= nums.length - 1 ? jumps : -1;
};