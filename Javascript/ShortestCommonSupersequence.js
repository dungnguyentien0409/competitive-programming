/**
 * Link: https://leetcode.com/problems/shortest-common-supersequence/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} str1
 * @param {string} str2
 * @return {string}
 */
var shortestCommonSupersequence = function(str1, str2) {
    if (str1.length == 0) return str2;
    if (str2.length == 0) return str1;
    
    var n1 = str1.length;
    var n2 = str2.length;
    var dp = findTheShortestCommonLength(str1, str2);
    
    var ans = buildString(str1, str2, dp);
    return ans;
};

function buildString(str1, str2, dp) {
    var m = str1.length;
    var n = str2.length;
    var res = '';
    
    while(m > 0 && n > 0) {
        if (str1[m - 1] == str2[n - 1]) {
            console.log(str1[m - 1]);
            res = str1[m - 1] + res;
            --m; --n;
        }
        // pick the result of str1(0...m-2) and str2(0...n-1). so the common supersequence should include the difference str1[m-1]
        else if (dp[m - 1][n] < dp[m][n - 1]) {
            res = str1[m - 1] + res;
            m--;
        }
        // pick the result of str1(0...m-1) and str2(0...n-2). so the common supersequence should include the difference str2[n-1]
        else {
            res = str2[n - 1] + res;
            n--;
        }
    }
    
    // include the rest of str1, if str2 finished
    while(m > 0) {
        res = str1[m - 1] + res;
        m--;
    }
    // include the rest of stre2, if str1 finished
    while(n > 0) {
        res = str2[n - 1] + res;
        n--;
    }
    
    return res;
}

function findTheShortestCommonLength(str1, str2) {
    if (str1.length == 0) return str2.length;
    if (str2.length == 0) return str1.length;
    
    var n1 = str1.length;
    var n2 = str2.length
    
    // dp[i][j] is the shortest common supersequence of str1(0,... i - 1) and str3(0,... i -2)
    var dp = Array(n1 + 1).fill().map(() => Array(n2 + 1).fill(0));
    
    for (var i = 0; i <= n1; i++) {
        for (var j = 0; j <= n2; j++) {
            if (i == 0)
                // the str1.length == 0, so the common of str1 and str2(0...j) is j
                dp[i][j] = j;
            else if (j == 0)
                // the str2.length == 0 , so the common of str1(0..i) and str2 is i
                dp[i][j] = i;
            else if (str1[i - 1] == str2[j - 1]) {
                dp[i][j] = 1 + dp[i - 1][j - 1];
            }
            else {
                dp[i][j] =  1 + Math.min(dp[i - 1][j], dp[i][j - 1]);
            }
        }
    }
    
    return dp;
}