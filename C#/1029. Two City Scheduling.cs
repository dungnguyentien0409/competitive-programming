/*
 * Link: https://leetcode.com/problems/two-city-scheduling/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int TwoCitySchedCost(int[][] costs) {
        Array.Sort(costs, delegate(int[] a, int[] b) {
            return (a[0] + b[1]) - (a[1] + b[0]);
        });
            
        int cost = 0;
        for (var i = 0; i < costs.Length; i++) {
            if (i < costs.Length / 2) {
                cost += costs[i][0];
            }
            else {
                cost += costs[i][1];
            }
        }
        
        return cost;
    }
}