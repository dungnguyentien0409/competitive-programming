/**
 * Problem: https://leetcode.com/problems/perfect-squares/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @return {number}
 */
var numSquares = function(n) {
    // create an array of square number having value less than or equal to n
    var squareNumbers = buildSquareNumbers(n);
    // dp[i] to store the least number suming to i
    var dp = Array(n + 1).fill(0);
    // there is one square number to sum to 1
    dp[1] = 1;
    
    for (var i = 2; i <= n; i++) {
        var minStep = Number.MAX_SAFE_INTEGER;
        for (var j = 0; j < squareNumbers.length; j++) {
            if (i >= squareNumbers[j] && dp[i - squareNumbers[j]] < minStep) {
                // for each number, get the min value of previous number which previous number + one specific number equal to that current number
                minStep = dp[i - squareNumbers[j]];
            }
        }
        //previous min step plus one
        dp[i] = minStep + 1;
    }
    
    return dp[n];
};

function buildSquareNumbers(n) {
    var i = Math.floor(n / 2) + 1;
    var res = [];
    
    while(i > 0) {
        if (i * i <= n) res.push(i * i);
        i--;
    }
    
    return res;
};