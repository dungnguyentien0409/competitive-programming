/*
 * Link: https://leetcode.com/problems/gas-station/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int start = gas.Length - 1, end = 0;
        int sum = gas[start] - cost[start];
        
        while(start > end) {
            if (sum >= 0) {
                sum += (gas[end] - cost[end]);
                ++end;
            }
            else {
                --start;
                sum += (gas[start] - cost[start]);
            }
        }
        
        return sum >= 0 ? start : -1;
    }
}