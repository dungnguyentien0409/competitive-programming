/*
 * Link: https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ShipWithinDays(int[] weights, int D) {
        var min = GetMinValue(weights);
        var max = GetMaxValue(weights);
        
        while(min < max) {
            var mid = min + (max - min) / 2;
            
            if (CheckResult(weights, D, mid)) {
                max = mid;
            }
            else {
                min = mid + 1;
            }
        }
        
        return min;
    }
    
    public bool CheckResult(int[] weights, int D, int mid) {
        var count = 0;
        var sum = 0;
        
        foreach (var w in weights) {
            sum += w;
            
            if (sum > mid) {
                sum = w;
                count++;
                
                if (count > D - 1) return false;
            }
        }
        
        return true;
    }
    
    public int GetMinValue(int[] weights) {
        var min = Int32.MinValue;
        
        foreach(var w in weights) min = Math.Max(min, w);
        
        return min;
    }
    
    public int GetMaxValue(int[] weights) {
        var max = 0;
        
        foreach(var w in weights) max += w;
        
        return max;
    }
}