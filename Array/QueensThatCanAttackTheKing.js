/**
 * Problem: https://leetcode.com/problems/queens-that-can-attack-the-king/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} queens
 * @param {number[]} king
 * @return {number[][]}
 */
var queensAttacktheKing = function(queens, king) {
    var res = [];
    
    var directions = [
        [0, 1], [0, -1], [1, 0], [-1, 0],
        [1, 1], [-1, -1], [1, -1], [-1, 1]
    ];
    
    for (var d of directions) {
        for (var i = 1; i <= 8; i++) {
            // start from the king position, expend to 8 direction. and because the chessboard is 8x8, we loop from i = 1 to i = 8
            var xQueen = king[0] + d[0] * i;
            var yQueen = king[1] + d[1] * i;
            var q = queens.filter(f => f[0] == xQueen && f[1] == yQueen)[0];
            
            if (q != null) {
                // after found the closest queen, break for that direction
                res.push(q);
                break;
            }
        }
    }
    
    return res;
};