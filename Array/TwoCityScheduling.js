/**
 * Problem: https://leetcode.com/problems/two-city-scheduling/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[][]} costs
 * @return {number}
 */
var twoCitySchedCost = function(costs) {
    costs.sort(function(p1, p2) {
        // order: p1 come to A, p2 to B is cheaper than p2 to A, p1 to B
        return (p1[0] + p2[1]) - (p1[1] + p2[0]);
    })
    
    console.log(costs);
    var total = 0;
    for (var i = 0; i < costs.length / 2; i++) {
        total += (costs[i][0] + costs[Math.floor(costs.length / 2) + i][1]);
    }
    
    return total;
};