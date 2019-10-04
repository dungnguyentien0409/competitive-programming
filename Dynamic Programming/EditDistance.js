/**
 * Problem: https://leetcode.com/problems/edit-distance/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} word1
 * @param {string} word2
 * @return {number}
 */
var minDistance = function(word1, word2) {
    word1 = word1.split('');
    word2 = word2.split('');
    
    var m = word1.length, n = word2.length;
    // d[i][j] is the mean way to convert the first i item of word1 to the first j item of word2
    var dp = [];
    
    for(var i = 0; i <= m; i++) {
        dp[i] = new Array(n);
    }
    
    for(var i = 0; i <= m; i++) {
        // if word1 has i item, word2 has 0 item, need to go through i ways to convert word1 to word2 (delete)
        dp[i][0] = i;
    }
    
    for (var j = 0; j <= n; j++) {
        // if word1 has 0 item, need to go through j ways to convert word1 to the first j item of word2
        dp[0][j] = j;
    }
    
    for (var i = 1; i <= m; i++) {
        for (var j = 1; j <= n; j++) {
            // if the next item i of word1 equal to the item j of word2, the way to convert is like the previous
            if (word1[i - 1] == word2[j - 1]){
                dp[i][j] = dp[i - 1][j - 1];
            }
            else {
                // find the min way to convert
                dp[i][j] = Math.min(dp[i - 1][j - 1] + 1, dp[i - 1][j] + 1, dp[i][j - 1] + 1);
            }
        }
    }
    console.log(dp);
    return dp[m][n];
};