/*
 * Probelm: https://www.spoj.com/problems/COINS/
 * Author: Dung Nguyen Tien (Chris)
*/
function changeCoins(n) {
  // dp[i] means the max dollar to change the amount of i (coin) to money
  var dp = Array(n + 1).fill(0);
  // the max value to change the coin of 4,3,2,1, 0 into money
  dp[0] = 0;
  dp[1] = 1;
  dp[2] = 2;
  dp[3] = 3;
  dp[4] = 4;
  
  for (var i = 5; i <= n; i++) {
    var i2 = Math.floor(i/2);
    var i3 = Math.floor(i/3);
    var i4 = Math.floor(i/4)
    // max of change the current coin to money or divide it and change
    dp[i] = Math.max(i, dp[i2] + dp[i3] + dp[i4]);
  }
  
  return dp[n];
}

document.writeln(changeCoins(12));