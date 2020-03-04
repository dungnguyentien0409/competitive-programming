/**
 * Link: https://leetcode.com/problems/max-points-on-a-line/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} points
 * @return {number}
 */
var maxPoints = function(points) {
    if (points.length <= 2) return points.length;
    var maxPoint = 0;
    
    for (var i = 0; i < points.length; i++) {
        var hashTable = {};
        var sameX = 1;
        var sameY = 1;
        var sameP = 0;
        
        for (var j = 0; j < points.length; j++) {
            if (i != j) {
                var p1 = points[i], p2 = points[j];
                var numerator = p1[1] - p2[1];
                var denominator = p1[0] - p2[0];
                
                // check the same point
                if (numerator == 0 && denominator == 0) ++sameP;
                else if (numerator == 0) sameX++;
                else if (denominator == 0) sameY++;
                else {
                    // check the same slope
                    var k = getK(numerator, denominator);
                    
                    hashTable[k] = (hashTable[k] || 1) + 1;
                    // if have slope, sameP substract one (duplicated the first point)
                    maxPoint = Math.max(maxPoint, hashTable[k] + sameP);
                }
                // in case of dont have slope, same P also count the first point
                maxPoint = Math.max(maxPoint, sameP + 1);
            }
        }
        maxPoint = Math.max(maxPoint, sameX, sameY);
    }
    
    return maxPoint;
};

function getK(numerator, denominator) {
    var gcd = getGcd(numerator, denominator);
    numerator /= gcd;
    denominator /= gcd;
    
    return numerator.toString() + "-" + denominator.toString();
}

function getGcd(a, b) {
    if (a == 0) return b;
    return getGcd(b % a, a);
}