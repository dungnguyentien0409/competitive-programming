/*
 * Link: https://leetcode.com/problems/minimize-max-distance-to-gas-station/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public double MinmaxGasDist(int[] stations, int K) {
        var min = 0.0;
        var max = (double)GetMaxValue(stations);
        var delta = Math.Pow(10, -6);
        
        while(min + delta < max) {
            var mid = min + (max - min) / 2;
            
            //Console.WriteLine(min + " " + max + " " + mid + " " + (min < max));
            if (CheckResult(stations, K, mid)) {
                max = mid;
            }
            else {
                min = mid;
            }
        }
        
        return max;
    }
    
    public bool CheckResult(int[] stations, int K, double mid) {
        var count = 0;
        
        for (var i = 1; i < stations.Length; i++) {
            count = count + (int)Math.Ceiling((stations[i] - stations[i - 1]) / mid) - 1;
            if (count > K) return false;
        }
        
        return true;
    }
    
    public int GetMinValue(int[] stations) {
        var min = Int32.MaxValue;
        
        for (var i = 1; i < stations.Length; i++) {
            min = Math.Min(min, stations[i] - stations[i - 1]);
        }
        
        return min;
    }
    
    public int GetMaxValue(int[] stations) {
        var max = Int32.MinValue;
        
        for (var i = 1; i < stations.Length; i++) {
            max = Math.Max(max, stations[i] - stations[i - 1]);
        }
        
        return max;
    }
}