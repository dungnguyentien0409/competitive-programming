/**
 * Link: https://leetcode.com/problems/last-stone-weight-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} stones
 * @return {number}
 */
var lastStoneWeightII = function(stones) {
    // divided into 2 group, one to detroys another one: S1, S2
    // S1 + S2 = S
    // S1 - S2 = diff => diff = S - 2*S2
    // get min diff => max S2 (S2 is from 0 => S/2)
    // the problem is, stone to get 0 => S/2: knapback
    var S = getTotal(stones);
    var S2 = 0;
    var dp = new Array(stones.length + 1).fill().map(() => Array(stones.length + 1).fill(false));
    for(var i = 0; i <= stones.length; i++) {
        // at the value 0, we can always get it by not pick
        dp[i][0] = true;
    }
        
    for (var i = 1; i <= stones.length; i++) {
        for (var j = 1; j <= S / 2; j++) {
            var remainWeight = j - stones[i - 1];
            if (remainWeight < 0) {
                // cannot pick
                dp[i][j] = dp[i - 1][j]
            }
            else {
                // consider pick or not
                dp[i][j] = dp[i - 1][j] // not pick
                           || dp[i - 1][remainWeight];
            }
            
            if (dp[i][j]) {
                // cant have that max S2
                S2 = Math.max(S2, j);
            }
        }
    }

    return S - 2 * S2;
};

function getTotal(stones) {
    var sum = 0;
    
    for (var s of stones) sum += s;
    
    return sum;
}