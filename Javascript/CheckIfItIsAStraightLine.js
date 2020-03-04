/**
 * Link: https://leetcode.com/problems/check-if-it-is-a-straight-line/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} coordinates
 * @return {boolean}
 */
var checkStraightLine = function(coordinates) {
    if (coordinates.length <= 2) return true;
    
    var x = coordinates[0];
    var y = coordinates[1];
    var k = '';
    var sameX = false;
    
    if (x[0] == y[0]) sameX = true;
    else {
        k = getKey(y[0] - x[0], y[1] - x[1]);
    }
    
    for (var i = 2; i < coordinates.length; i++) {
        var point = coordinates[i];
        
        if (sameX && point[0] != x[0]) return false;
        else if (getKey(point[0] - x[0], point[1] - x[1]) != k) return false;
    }
    
    return true;
};

function getKey(x, y) {
    var gcd = getGcd(x, y);
    x = x % gcd;
    y = y % gcd;
    
    return x.toString() + "-" + y.toString();
}

function getGcd(a, b) {
    if (a == 0) return b;
    return (b % a, a);
}