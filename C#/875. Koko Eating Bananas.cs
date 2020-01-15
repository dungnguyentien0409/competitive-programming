/*
 * Link: https://leetcode.com/problems/koko-eating-bananas/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinEatingSpeed(int[] piles, int H) {
        var min = 1;
        var max = GetMaxValue(piles);
        
        while(min < max) {
            var mid = min + (max - min) / 2;
            
            Console.WriteLine(min + " " + max + " " + mid);
            if (CheckResult(piles, H, mid)) {
                max = mid;
            }
            else {
                min = mid + 1;
            }
        }
        
        return max;
    }
    
    public bool CheckResult(int[] piles, int H, int mid) {
        var hour = 0;
        
        foreach(var p in piles) {
            hour += (int)Math.Ceiling((p * 1.0) / (mid * 1.0));
            
            if (hour > H) return false;
        }

        return true;
    }
    
    public int GetMaxValue(int[] piles) {
        var max = 0;
        
        foreach(var pile in piles) max = Math.Max(max, pile);
        
        return max;
    }
}