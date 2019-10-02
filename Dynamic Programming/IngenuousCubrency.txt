/*
 * Probelm: https://www.spoj.com/problems/COINS/
 * Author: Dung Nguyen Tien (Chris)
*/

function countWayToPay(n) {
  var coins = buidArrayCoin(n);
  // dp[i] mean the total way to pay for the money of i
  var dp = Array(n + 1).fill(0);
  // dp[0] just to calculate. 
  dp[0] = 1;
  
  for(var i = 1; i <= coins.length; i++) {
    // for each coin, put it into the dp
    // if the total moeny of that dp bigger than coin, mean can pay with that coin
    for (var j = coins[i]; j <= n; j++) {
      //for example: 1 way to pay for 1->8
      // at 8 we have 2 way: dp[8] = dp[8] + dp[8 - 8] = 2(11111111; 8)
      // at 9 we have 2 way: dp[9] = dp[9] + dp[9 - 8] = 2(111111111; 811111111)
      // at 16 we have 4 way: dp[16] = dp[15] + dp[8] = 4 
      dp[j] += dp[j - coins[i]]; 
    }
  }
  document.writeln(JSON.stringify(coins));
  
  return dp[n];
}

function buidArrayCoin(n) {
  var res = [0];
  var i = 1;
  
  while(Math.pow(i, 3) < n && i <= 21) res.push(Math.pow(i++, 3));
  
  return res;
}

document.writeln(countWayToPay(9999));