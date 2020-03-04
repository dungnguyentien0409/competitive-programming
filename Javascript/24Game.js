/**
 * Link: https://leetcode.com/problems/24-game/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} nums
 * @return {boolean}
 */
var res = [];
var judgePoint24 = function(nums) {
    // until the nums has only one result, because the result can be decimal, we need to check if it is 24 or to be rounded to 24
    if (nums.length == 1) {
        if (Math.round(nums[0] * 10) / 10 == 24)
            console.log(res);
        return Math.round(nums[0] * 10) / 10 == 24;
    }
    
    // try to do math operation: +-*/ for each paris of item then push the result back to the array - solve it by 2 for loop
    for (var i = 0; i < nums.length; i++) {
        for (var j = 0; j < nums.length; j++) {
            if (i == j) continue;
            
            var small = Math.min(i, j);
            var large = Math.max(i, j);
            var thisCards = nums.slice();
            
            thisCards.splice(large, 1);
            thisCards.splice(small, 1);
            
            var iValue = nums[i];
            var jValue = nums[j];
            var isValid = false;
            isValid = isValid || judgePoint24([iValue + jValue, ...thisCards]);
            if (isValid) res.push(iValue + "+" + jValue);
            isValid = isValid || judgePoint24([iValue - jValue, ...thisCards]);
            if (isValid) res.push(iValue + "-" + jValue);
            isValid = isValid || judgePoint24([iValue * jValue, ...thisCards]);
            if (isValid) res.push(iValue + "*" + jValue);
            if (jValue != 0) {
                isValid = isValid || judgePoint24([iValue / jValue, ...thisCards]);
                if (isValid) res.push(iValue + "/" + jValue);
            }
            
            if (isValid) return isValid;
        }
    }
    
    return isValid;
};