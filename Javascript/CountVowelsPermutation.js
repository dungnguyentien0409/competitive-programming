/**
 * Link: https://leetcode.com/problems/count-vowels-permutation/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @return {number}
 */
var countVowelPermutation = function(n) {
    return count(n);
};
var res;

function count(n) {
    // a = 0, e = 1, i = 2, o = 3, u = 4
    // dp[i][j] => the total vowels permutation length i end with j
    var dp = Array(n + 1).fill().map(() => Array(5).fill(0));
    var max = Math.pow(10, 9) + 7;
    
    // the total vowels permutation end with "a,e,i,o,u", length 1 is 1
    for(var len = 0; len < 5; len++) {
        dp[1][len] = 1;
    }
    
    for (var len = 2; len <= n; len++) {
        // length i, end with a: a can go after: e, i, u
        dp[len][0] = (dp[len - 1][1] + dp[len -1][2] + dp[len - 1][4]) % max;
        
        //length len, end with e: e can go after: a, i
        dp[len][1] = (dp[len - 1][0] + dp[len - 1][2]) % max;
        
        // length len, end with i: i can go after: e, o
        dp[len][2] = (dp[len - 1][1] + dp[len - 1][3]) % max;
        
        // length len, end with o: o can go after: i
        dp[len][3] = dp[len - 1][2]
        
        // length len, end with u: u can go after: i, o
        dp[len][4] = (dp[len - 1][2] + dp[len - 1][3]) % max;
    }
    console.log(dp);
    // count the total dp[len][i] end with a,e,i,o,u
    var res = 0;
    for (var i = 0; i < 5; i++){
        res += dp[n][i];
    }
    
    return res % max;
}