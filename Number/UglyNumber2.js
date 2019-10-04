/**
 * Problem: https://leetcode.com/problems/ugly-number-ii/submissions/
 * Author: Dung Nguyen Tien Chris
 * @param {number} n
 * @return {number}
 */
var nthUglyNumber = function(n) {
    var dp = Array(n);
    dp[0] = 1;
    
    //idea: at first i2,i3,i5 point to position 0 whose value is 1
    // the next value is 2, increase i2 to 1, i3, i5 point to 0, then keep going
    // there are special cases: 6, 15, 30,.... which there are 2 pointer giving same calculation value in the operation Math.min, we need to increase both, that why keep using if, not else
    var index2 = 0, index3 = 0, index5 = 0;
    
    for (var i = 1; i < n; i++) {
        dp[i] = Math.min(dp[index2] * 2, dp[index3] * 3, dp[index5] * 5);
        
        if (dp[i] == dp[index2] * 2) index2++;
        if (dp[i] == dp[index3] * 3) index3++;
        if (dp[i] == dp[index5] * 5) index5++;
    }
    console.log(dp);
    return dp[n - 1];
};