/*
 * Link: https://leetcode.com/problems/teemo-attacking/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        var total = 0;
        
        for (var i = 0; i < timeSeries.Length; i++) {
            if (i == timeSeries.Length - 1) {
                total += duration;
            }
            else {
                total += Math.Min(duration, timeSeries[i + 1] - timeSeries[i]);
            }
        }
        
        return total;
    }
}