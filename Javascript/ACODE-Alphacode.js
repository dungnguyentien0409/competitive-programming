/*
 * Link: https://www.spoj.com/problems/ACODE/
 * Author: Dung Nguyen Tien (Chris)
*/
function countWayDecodings(s) {
  // Idea: if we have 431 and we add 1. 
  // the first way is all the ways of (432) adding 1 to the end
  // the second way is all the ways of (43) adding 21 to the end (if 21 >= 10 and 21 <= 26)
  var dp = Array(s.length + 1).fill(0);
  // just to calculate
  dp[0] = 1;

  // i is the length of considering number
  for (var i = 1; i <= s.length; i++) {
    var index = i - 1; // point to the number of s, from 0 to s.length - 1
    // the first way
    if (s[index] > '0')
      dp[i] += dp[i - 1];
    
    var lastNumber = s[index - 1] + s[index];
    // the secondway
    if (index - 1 >= 0 && lastNumber >= '10' && lastNumber< '27')
      dp[i] += dp[i - 2];
  }

  return dp[s.length];
}

document.writeln(countWayDecodings('25114'));