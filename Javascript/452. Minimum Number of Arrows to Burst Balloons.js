/**
 * Link: https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} points
 * @return {number}
 */
var findMinArrowShots = function(points) {
    if (points.length == 0) return 0;
    
    points.sort(function(a, b) { return a[1] - b[1] });
    
    // attack the first ballon and difine the range can be attacked
    var arrows  = 1;
    var canAttack = [points[0][0], points[0][1]];
    
    for (var i = 1; i < points.length; i++) {
        // if the next ballon out of the range can be attacked, increase arrows 
        if (points[i][0] > canAttack[1]) {
            arrows ++;
            canAttack = points[i];
        }
        else {
            // if the next value in the current range, define the new range can be attacked
            var x = Math.max(points[i][0], canAttack[0]);
            var y = Math.min(points[i][1], canAttack[1]);
            canAttack = [x,y];
        }
    }
    
    return arrows ;
};