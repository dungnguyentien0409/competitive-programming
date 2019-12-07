/*
 * Problem: https://codepen.io/pen/?editors=1010
 * Author: Dung Nguyen Tien (Chris)
 * Idea: Tushar Roy
 * Reference: https://www.youtube.com/watch?v=8LusJS5-AGo
*/

function knapsack(val, wt, W) {
  var dp = Array(val.length + 1).fill().map(() => Array(W + 1).fill(0));
  
  for (var i = 1; i <= val.length; i++) {
    for (var j = 1; j <= W; j++) {
      var remainWeight = j - wt[i - 1];
      if (remainWeight < 0) {
        // cannot pick the item
        dp[i][j] = dp[i - 1][j];
      }
      else {
        // can pick the item: consider pick or not pick
        dp[i][j] = Math.max(dp[i - 1][j], // not pick
                            dp[i - 1][remainWeight] + val[i - 1]); // pick the item and push the max val for the remain weight;
      }
    }
  }
  
  return dp[val.length][W];
}

var wt = [10, 20, 30];
var val = [60, 100, 120];
document.writeln(knapsack(val, wt, 50));